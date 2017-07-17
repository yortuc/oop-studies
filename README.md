# OOP Design Principles
### 1. Open closed principle
Classes should be open for extension, but closed for modification.

Our goal is to allow classes to be easily extended to incorporate new behavior without modifying existing code. What do we get if we accomplish this? Designs that are resilient to change and flexible enough to take on new functionality to meet changing requirements.

**Why not altering the code of class?**
We spent a lot of time getting this code correct and bug free, so we can’t let you alter the existing code. It must remain closed to modification. If you don’t like it, you can speak to the manager.


**Warning:**
Following the Open-Closed Principle usually introduces new levels of abstraction, which adds complexity to our code. You want to concentrate on those areas that are most likely to change in your designs and apply the principles there.



# Tips
1. Code against interface, not concrete implementations. When you see “new”, think “concrete”.
2. Depend upon abstractions. Do not depend upon concrete classes.



# Design Patterns

### 1. Strategy
Seperate the implementation of some behavior of a class. For example, Duck quacking can be seperated as a behavior class which implemets a, `QuackBehavior` interface. Every ducking behavior is implemented as a seperate class. From duck to duck, this behavior can be changed. Even in runtime, it can be changed. For tax calculation, each calculation method (that depends on country or state) can be implemented as a seperate class and can be referenced from mail class via an interface like `TaxCalculator`.

### 2. Observable
Oberserver: subject -> publisher, observer -> subscribers
Subjects, or as we also know them, Observables, update Observers using a common interface.

### 3. Decorator
The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

### 4. Factory Pattern
Factories handle the details of object creation. The Factory Method Pattern encapsulates object creation by letting subclasses decide what objects to create. 
The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### 5. Singleton
The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

One flaw of the singleton is not being thread-safe at first. You need to modify initial instance creation method thread locked that before one thread finishes the execution, no other thread sould run the method. `Synchronized` keyword for Java and `[MethodImpl(MethodImplOptions.Synchronized)]` for C#.

### 6. Command Pattern : Encapsulating Invocation
The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.



----

### Example OOP design problems
1. https://github.com/gmershad/FoodDeliveryApp