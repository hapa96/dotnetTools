# ScaffoldMediator

This dotnet Tool creates all the classes that are needed to fullfill the Mediator pattern. It creates a new Folder in the current directory, this tool gets executed. Within this folder are the following three files:  `Command.cs`, `CommanHandler` and `CommandValidator`

Usage:

```
Usage: dotnet run <actionName> <namespace>
```

The namespace should be the toplevel namespace (without the actionName in it)

 Note, that this tool was written for Projects, that are structured in featureFolders. 