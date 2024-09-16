#!/bin/bash

set -eou pipefail

host=http://localhost:5091

http post $host/api/Question title=string

http post $host/api/Answer title=string questionId:=1

http post $host/api/Poll title=string

http post $host/api/Instance title=string pollId:=1
