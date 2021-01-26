# Teams Selection
## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is a solution of the proposed challenge of finding groups of 3-distinct person given an array of 5 members. 
	
## Technologies
Project is created with:
* .NET Core: 2.0
	
## Setup
To run this project, install it locally cloing the repository using git in a terminal:

```
$ git clone https://github.com/fredrodlima/teamsselection.git
$ cd .\teamsselection
```

Alternatively, you also can download the code directly from repository as a zip file. Then you should extract its contents to a local folder in your machine.

### Visual Studio Code
The development of the solution was done using Visual Studio Code. If you don't have it installed you can download from https://code.visualstudio.com/download.
If you already have it installed, open it on your PC and open the project folder you have cloned or extracted the files from repository.

In order to prepare the solution for run it properly you can restore the libraries for all projects running the following command
```
$ dotnet restore
```

Then to see the the output you should run the following command in Visual Studio Code terminal
```
$ dotnet run --project=TeamsSelection
```
It is included one test, as an example of unit tests, to check the ammount of results returned by the implemented solution. To check it out you can run the following
```
$ cd .\TeamsSelection.Tests\
$ dotnet test
```
