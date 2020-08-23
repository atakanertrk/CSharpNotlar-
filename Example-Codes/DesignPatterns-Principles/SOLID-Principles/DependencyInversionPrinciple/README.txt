## Dependency Inversion Principle
* High-level modules should not depend on low-level modules (high-level models: depends other modules, low-level modules: not depends anything)
* Main modules should depend abstractions and those abstractions should not depend on details
> For Chore.cs class, with dependency inversion, we dont have to keep creating new instances. We use abstraction, interface and constructors.
> If we want change things in main classes, main classes not have direct dependings, they are depending to abstractions(interfaces) 
> So we can change anything without break the app