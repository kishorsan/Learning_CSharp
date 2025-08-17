## How to create a new console project

>dotnet new console -o ./ProjectName

## How to run the program
* Goto the ProjectName folder
* Execute the below command
>dotnet build

* Use below command to run the code
>dotnet run

### Statefull versus Stateless methods

* Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.

* Oftentimes, the terms 'parameter' and 'argument' are used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

* Console.WriteLine() method has 19 different overloaded versions.