# Introduction

This is the step to using the application on Digital Ocean or Vultr. (I have not used it on Vultr before but you are free to try it out and get back to me).

Kindly follow these steps:

## Step 1 (Register at digital ocean)

If you already have an account kindly skip this step.

With each passing day the requirements for creating an account in digital ocean is becoming combersome but this is all for security. Please be patient and follow there instructions.

Visit [Digital Ocean](https://cloud.digitalocean.com/registrations/new) to create an account

## step 2 (Create a droplet)

Within your account select create a droplet and look at the marketplace for docker in ubuntu, select that and fill in the required information to fit your desires. You should create an ssh (follow the instruction on how to create an ssh when you get to that part, its easy).

## stwp 3 (Create another user)

kindly follow this [Instruction](https://www.digitalocean.com/community/tutorials/initial-server-setup-with-ubuntu-18-04) on how to create another user.

## Create the folder structure

Ssh into the Droplet (Virtual machine) and create folders inside the user's account (the other user created in step 3 and this should be in "/home/{user}/app"). first create the app folder and cd into that.

The following folders should be created:

     ### src (/home/{user}/app/src)
          This will contain the application source code from the repo.

     ### db (/home/{user}/app/db)
          This will contain the database file. This should only be used for staging. In the cause of this project Sqlite will be used for staging. A database will be used when required.
          * StagingDb.db: create this file inside this folder.

     ### config (/home/{user}/app/config)
          This folder contains the necessary files for making sure the application runs according to my plan. This contains the following:

               * redeploy.sh: this is used for Continous Integration. (i.e. it executes when an maerge has been made in the repo). Copy the content of the config/redeploy.sh in to here. Give neccarry permission to user and application.
                    `` sudo chmod +x /home/agent/app/config/redeploy.sh `` 
                    `` sudo chmod 755 /home/agent/app/config/redeploy.sh ``
                    `` sudo visudo  `` and
                    `` www-data ALL=NOPASSWD: /home/agent/app/config/redeploy.sh ``
               Please endevour to check this file properly for the git address, the images being pulled etc. thanks


               * env.json: This contains all your environment variables. I had difficulties accessing 
               the values from the O.S. Pust all your environment variable here please.

               * __webhook.php: Used for web hooks sent from the desired repo. It validates the request and exexutes the redeploy.sh file. This file will be moved to a different folder later down the tutorial.

               * domain.conf: This is the server block for your domain name and it will be used when installing Nginx

## Install Nginx

THe purpose of installing nginx outside the docker-compose is for C.I. Web hooks from the repo can be sent to the ngix to activite the __webhook.php in other to execute the redeploy.sh file.

Read [this instructions](https://www.digitalocean.com/community/tutorials/how-to-install-linux-nginx-mariadb-php-lemp-stack-on-debian-10) on how to install nginx on ubuntu.

`` watch out for nano /var/www/your_domain/info.php, it should be nano /var/www/your_domain/html/info.php ``

copy the content of domain.conf when creating your server block. (remember to change the domain name to your desired name).

## php file for webhook

You need Php to be installed to all Nginx use it Kindly read [this](https://www.digitalocean.com/community/tutorials/how-to-install-linux-nginx-mysql-php-lemp-stack-ubuntu-18-04).

This is for handling changes made to the repo to enable C.I.  This in involves creating a file in the html folder of the nginx domain.
     `` sudo nano /var/www/html/__webhook.php ``

copy the contents of config/__webhook.php into this file. Read through to figure the requirements you need. either github or Azure devops. configure as required.

## Install lets encrypt (optional)

This is to use ssl for your application. kindly read [this] (https://haydenjames.io/how-to-set-up-an-nginx-certbot/) or [this](https://www.digitalocean.com/community/tutorials/how-to-secure-nginx-with-let-s-encrypt-on-ubuntu-18-04).
