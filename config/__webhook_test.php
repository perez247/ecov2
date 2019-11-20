<?php

$globalEnv = json_decode(file_get_contents("/home/agent/app/config/env.json"));
foreach ($globalEnv as $key=>$value){
        putenv($key.'='.$value);
}


if ($_SERVER['PHP_AUTH_PW'] == $globalEnv->WEBHOOK_SECRET)
    {
        shell_exec('sudo -E /home/agent/app/config/redeploy.sh > /tmp/redeploy_docker.txt & printf "%u" $!');
        // file_put_contents('/tmp/azure.txt', print_r($_SERVER['PHP_AUTH_PW'], true));
        // It is very important that you create a friendly environment
        
    }
else {
    throw new \Exception("Failed to rebuild");
}
