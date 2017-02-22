#!/bin/bash

echo "Nginx is running..."

exec nginx -c /etc/nginx/nginx.conf -g "daemon off;"
