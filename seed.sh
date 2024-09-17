#!/bin/bash

set -eou pipefail

host=http://localhost:5091

http post $host/api/Question title=string

http post $host/api/Answer title=string questionId:=1

http post $host/api/Poll title=string

http post $host/api/Instance title=string pollId:=1

http post $host/api/InstanceQuestion instanceId:=1 questionId:=1

http post $host/api/InstanceAnswer instanceQuestionId:=1 text=ok
