<?php
/**
 * GitHub webhook handler template. and excellence
 * 
 * @see  https://developer.github.com/webhooks/
 * @author  Miloslav Hůla (https://github.com/milo)
 */
$globalEnv = json_decode(file_get_contents("/home/agent/config/env.json"));
foreach ($globalEnv as $key=>$value){
        putenv($key.'='.$value);
}

$refValue = 'refs/heads/develop'; $refKey = 'ref'; # Choose the branch you want
$repositoryKey = 'repository'; 
$timePushed = 'pushed_at'; # When the code was pushed
$timePushedExpires = 2; # Dont redeploy the same hook when time exceeds 2mins
$hookSecret = $globalEnv->GITHUB_WEBHOOK_SECRET;  # set NULL to disable check
set_error_handler(function($severity, $message, $file, $line) {
	throw new \ErrorException($message, 0, $severity, $file, $line);
});
set_exception_handler(function($e) {
	header('HTTP/1.1 500 Internal Server Error');
	echo "Error {$e->getLine()}: " . htmlSpecialChars($e->getMessage());
	die();
});
$rawPost = NULL;
if ($hookSecret !== NULL) {
	if (!isset($_SERVER['HTTP_X_HUB_SIGNATURE'])) {
		throw new \Exception("HTTP header 'X-Hub-Signature' is missing.");
	} elseif (!extension_loaded('hash')) {
		throw new \Exception("Missing 'hash' extension to check the secret code validity.");
	}
	list($algo, $hash) = explode('=', $_SERVER['HTTP_X_HUB_SIGNATURE'], 2) + array('', '');
	if (!in_array($algo, hash_algos(), TRUE)) {
		throw new \Exception("Hash algorithm '$algo' is not supported.");
	}
	$rawPost = file_get_contents('php://input');
	if ($hash !== hash_hmac($algo, $rawPost, $hookSecret)) {
		throw new \Exception('Hook secret does not match.');
        }
        $payLoad = json_decode($rawPost, true);
        if (!array_key_exists($refKey, $payLoad) || $payLoad[$refKey]!== $refValue){
            throw new \Exception('Invalid ref property');
        }
    
        if (array_key_exists($repositoryKey, $payLoad) && array_key_exists($timePushed, $payLoad[$repositoryKey])){
            $hr = round((time() - $payLoad[$repositoryKey][$timePushed])/60, 0);
            if ($hr > $timePushedExpires)
                    throw new \Exception('This push time has expired, kindly create another push');
      }
};
if (!isset($_SERVER['HTTP_CONTENT_TYPE'])) {
	throw new \Exception("Missing HTTP 'Content-Type' header.");
} elseif (!isset($_SERVER['HTTP_X_GITHUB_EVENT'])) {
	throw new \Exception("Missing HTTP 'X-Github-Event' header.");
}
switch ($_SERVER['HTTP_CONTENT_TYPE']) {
	case 'application/json':
		$json = $rawPost ?: file_get_contents('php://input');
		break;
	case 'application/x-www-form-urlencoded':
		$json = $_POST['payload'];
		break;
	default:
		throw new \Exception("Unsupported content type: $_SERVER[HTTP_CONTENT_TYPE]");
}
# Payload structure depends on triggered event
# https://developer.github.com/v3/activity/events/types/
$payload = json_decode($json);
switch (strtolower($_SERVER['HTTP_X_GITHUB_EVENT'])) {
	case 'ping':
		echo 'pong';
		break;
    
    case 'push':
        echo 'working push command';
        shell_exec('sudo -E /home/agent/app/config/redeploy.sh > /tmp/redeploy_docker.txt & printf "%u" $!');
        
		break;
//	case 'create':
//		break;
	default:
		header('HTTP/1.0 404 Not Found');
		echo "Event:$_SERVER[HTTP_X_GITHUB_EVENT] Payload:\n";
		print_r($payload); # For debug only. Can be found in GitHub hook log.
		die();
}