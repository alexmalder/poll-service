#!/bin/bash

set -eo pipefail

rm -rfv ./Migrations/*

dotnet ef database drop --force
dotnet ef migrations add initial
dotnet ef database update

#http post 
