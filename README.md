# AutomationProject
Learn Selenium and C#
This project is to help the member of the Sogeti community become more familiar with git, c#, and selenium as well as create a demo ready product to help show the power of automation.
This project plans to have multiple branches, however starting out the master will be a tutorial branch showing the basics of selenium and how to set up a test case. 

# Tutorial:
For those who have not used git before, git is a version control solution that help to coordinate collaboration on code across many different users. Github is a service that hosts git repositories to allow users to access and distribute their code and even more easily collaborate on code. 

There are several great resources for learning git such as https://learngitbranching.js.org/ which can offer a through visual explanation of how git works. 

To start working on this project you will first need to clone the repository. This can be done in a GUI or using the git clone <url> command. This will create a local version to work on. 

# Getting started:
First pull down the most recent branch of the project
Navigate to AutomationProject/SelTest
Build the project which should create a bin folder and a obj folder 
Download the appropriate gecko driver from https://github.com/mozilla/geckodriver/releases (Most likely the windows 64 bit download.)
Move the geckodriver.exe into the AutomationProject/SelBasic folder and into the AutomationProject/SelTest/Bin/Debug/netcoreapp2.1 folder.
To run the project in the command line type dotnet test

# Getting started:
To run specific test follow the documentation on https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test?tabs=netcore21

examples are listed under cheetsheet

# cheat Sheet:
Run test by name: dotnet test --filter name~BBHomeTestDevSup
run test by catagory: dotnet test --filter testcategory~Tutorial
web driver needs to be in same folder as csproj and in test/debug/netcoreapp
