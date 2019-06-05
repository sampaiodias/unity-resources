# SOLID Item System

Example project to showcase [SOLID](https://en.wikipedia.org/wiki/SOLID) usage for a ficticious item system. This is not a complete system!

* Single Responsibility
	* Classes on this project should only have a single responsibility (as much as possible).
* Open Closed
	* The available systems are fully open to extension with Interfaces and Abstract classes (e.g.: Create a new type of item inheriting from Item).
* Liskov's Substitution
	* Diferent implementations of the same class are interchangeable (e.g.: classes Player and Character).
* Interface Segregation](Assets/Scripts/Interface%20Segregation)
	* Interfaces only serve a single purpose, containing a few methods only but preferably a single method (e.g. interface IUsable).
* Dependency Inversion
	* Each concrete class that inherits from Item (or one of its sub-classes) know exactly what to do when they are activated, instead of delegating this behaviour to another class (like Character or PlayerController, for example).