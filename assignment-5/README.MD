# Assignment 4 
## Analysing Log Data

<br></br>
# How to run
Open a terminal at the root of this project and run `dotnet run` .

If you don't have c# installed on your computer the project is also dockerized. 

### Commands for docker

create an image:

`docker build -t <some-name-here> .`

run image: 

`docker run -it --rm <some-name-here>`

# Problems and goals

## What we achieved
We managed to finish part one of the assignment. When running the project you first see which states the program goes through, followed by a list of all instances both completed and not completed, wherefrom you can gather the information to which instances are stuck at a non final state and which instances are running. Under the folder `log` there's a `log.txt` file which contains all logs from all actions made when running the program. We've decided not to include warnings in the log as seen in `LogUtility.cs` since there isn't going to be a time where we'd actually get a warning. 

We did manage to be able to auto generate the states for the example given in part two of the assignment. This was tricky and is still not perfect, some inputs create errors while others work fine. With more time it would need some heavy fine tuning, but for the sake of the exercise, it works. We've decided not to do the task that checks on how long time the instance had been running, since we were told this part of the exercise wasn't that important, and we've focused more of our time on understanding the logic of auto generating states. 
