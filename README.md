# kubernetes-net-core-noob
This is the sample repo for the kubernetes hello world sort of

1. Clone the repo
2. Once set launch vs code
3. Build docker file [terminal, make sure you launch docker quickstart terminal]

```
docker build --rm -f "Dockerfile" -t kubernetes-net-core-noob:latest .
```

4. Run dokcer with image which you created

```
docker run -p 80:80 kubernetes-net-core-noob:latest
```

5. now you can docker deployed url with this below

http://192.168.99.100/api/auth

NOTE. If you get any error check docker ps , see if the instances are running stop using 

```
docker stop NAME
```


