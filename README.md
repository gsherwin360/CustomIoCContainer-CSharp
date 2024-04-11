# Custom IoC Container
This project implements a basic custom IoC (**Inversion of Control**) container in **C#**, aimed at simplifying dependency management and enhancing decoupling between software components.

## Introduction
In software engineering, IoC, or Inversion of Control, is a design principle that advocates for transferring the control of flow and dependency management from individual components to higher-level frameworks or containers. This promotes loose coupling and enhances system flexibility, scalability, and testability.

## IoC Principles
Before exploring the features and usage of this project, let's briefly discuss the two key IoC principles:
- **Dependency Inversion Principle (DIP):** This principle promotes decoupling between high-level and low-level modules by abstracting dependencies through interfaces or abstract classes.
- **Dependency Injection (DI):** DI is a design pattern that implements DIP by providing dependencies to a class from external sources. This improves loose coupling and testability by allowing components to be easily replaced or mocked during testing.
  
## IoC Containers
IoC containers or frameworks, such as the one implemented in this project, are tools used to facilitate the implementation of IoC principles, including DIP and DI. They manage the creation and resolution of dependencies, providing control over the lifetime of objects and enabling developers to focus on business logic rather than manual dependency management.

## Features
- **Dependency Registration:** Register dependencies with ease into the IoC Container, making them available for resolution.
- **Dependency Resolution:** Resolves dependencies and instantiates objects, simplifying complex dependency management tasks.
- **Dependency Lifetime Management:** Control the lifespan of dependencies with options like Singleton or Transient, providing flexibility in how dependencies are created and managed within the application.

## Usage
This project includes a basic user management system that utilizes the IoC container for dependency injection. It allows for adding and printing users through a console interface, demonstrating the usage of the IoC container.
