#!/bin/bash

echo "******************** Starting redeploy script ******************************"
giturl="https://github.com/perez247/ecov2.git"
api_image="newecopeoplev1/backend_dev:latest"
front_image="newecopeoplev1/frontend_dev:latest"

docker_compose_file="docker-compose.staging.yml"

app_path="/home/agent/app/src"

db="/home/agent/app/db/StagingDB.db"

echo "******************** Checking App folder ******************************"
if [ ! -d $app_path  ]
then
    echo "******************** Creating App Folder ******************************"
    sudo mkdir $app_path
fi

if [ ! "$(ls -A $app_path)" ]
then 
    echo "******************** Cloning git repo ******************************"
    sudo git clone $giturl $app_path
fi

if test ! -f $db ; then
     echo "******************** Creating Db Folder ******************************"
    sudo mkdir -p /home/agent/app/db
    sudo touch $db
    else
     echo "******************** Cannot create folder ******************************"
fi

cd $app_path

echo "******************** Get updated pull ******************************"
sudo git pull

echo "******************** Switching to desired branch you can set this in the redeploy-github-hook.sh ******************************"
sudo git checkout develop

echo "******************** Shutting down docker-compose ******************************"
sudo -E docker-compose -f "${app_path}/${docker_compose_file}" down

echo "******************** Pulling docker-compose image ******************************"

sudo docker pull $api_image
sudo docker pull $front_image

echo "******************** Starting docker-compose image ******************************"
sudo -E docker-compose -f "${app_path}/${docker_compose_file}" up --build logs > /tmp/docker-compse-log.txt