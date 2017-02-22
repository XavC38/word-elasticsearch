# How to start a ftp server

follow the step from this website.
https://docs.ovh.com/pages/releaseview.action?pageId=18122833

Then run to check if it is up and running
```
/etc/init.d/proftpd status
```

You can stop by doing
```
/etc/init.d/proftpd stop
```

and start by
```
/etc/init.d/proftpd start
```

Once it is done, you can connect using your host and credentials informations:
* sftp://vps329586.ovh.net
* user
* pwd
* port 21
