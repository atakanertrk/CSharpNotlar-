## In this example:
* Sample Dependency Injection with Autofac
> First applied dependency inversion principle (D in SOLID) <br/>
> Then used Autofac to handle connecting the various dependencies togather. <br/>
> With one change in one spot (in ContainerConfig.cs with changing BusinessLogic or BetterBusinessLogic when application asks for IBusinessLogic item) we are able to change how application will work because its not tightly coupled togather (dependency inversion)

## What is dependency injection:
> Dependency Injection (DI) is a design pattern used to implement IoC. It allows the creation of dependent objects outside of a class and provides those objects to a class through different ways.
> In software engineering, inversion of control (IoC) is a programming principle. ... In IoC, custom-written portions of a computer program receive the flow of control from a generic framework.

## Note: asp.net core mvc, web api, .net core have additional configuration because they have sort of dependency injecion already. This example can be use for win forms, wpf etc...
## Note: Dependenct inversion is princple to make classes less depends eachother and dependency injection is implementation this concept. Autofac is extension for dependency injection.