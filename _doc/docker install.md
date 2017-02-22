# Docker server installation

```
docker run -d --name elasticword1 -p 9200:9200 -e CLUSTER=elasticword elasticsearch
```
https://hub.docker.com/r/itzg/elasticsearch/

```bash
curl -XGET 'http://localhost:9200/?pretty'
```

### create and remove error

To create a docker image, create a `Dockerfile` file,
with all depandant files with it. you can check to proxy folder for an example.

then go on the folder and do
```
docker build . -t imagename
```
the image is created and can be launched.

to remove an image just run :
```
docker rmi imageid
```


### remove all exited application
```
 docker rm $(docker ps -a -q -f status=exited)
```

### docker link

when docker is creating a link, it generate a global var to access to the link container information. You need to go into the container to access to the env variable.

So, we create a link :
```
docker run --name elastic -d itzg/elasticsearch
```
**elastic** container has automatically port open on 9200. but no port on the host is open, since there is no -p attribute.

```
docker run -p 8080:8080 --name proxy --link elastic -d nginx2
```


```
docker exec -i -t proxy /bin/bash
```
then we check the global var by doing
```
env
```

we have the following result
```
ELASTIC_PORT_9300_TCP_PROTO=tcp
ELASTIC_PORT=tcp://172.17.0.2:9200
ELASTIC_ENV_LANG=C.UTF-8
ELASTIC_ENV_DEFAULT_ES_USER=elasticsearch
ELASTIC_PORT_9200_TCP_PORT=9200
```
global var are created from the link

### authorize access of a file
```
chmod a+x filename
```

with it, we can create execute a file from docker container.

You can check on the file right on :
```
ls -al
```
