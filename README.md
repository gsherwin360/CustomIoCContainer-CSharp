# Custom IoC Container

This project implements a basic custom IoC (**Inversion of Control**) container in **C#**, aimed at simplifying dependency management and enhancing decoupling between software components.

IoC involves transferring control and dependency management from individual components to higher-level frameworks or containers, promoting loose coupling and enhancing system flexibility, scalability, and testability.

This project aligns with key IoC principles, including the **Dependency Inversion Principle (DIP)** and **Dependency Injection (DI)**. DIP promotes decoupling between high-level and low-level modules by abstracting dependencies through interfaces or abstract classes. DI, a design pattern, implements DIP by providing dependencies to a class from external sources, improving loose coupling and testability.

## IoC Containers

IoC containers or frameworks, such as the one implemented in this project, are tools used to facilitate the implementation of IoC principles, including DIP and DI. They manage the creation and resolution of dependencies, providing control over the lifetime of objects and enabling developers to focus on business logic rather than manual dependency management.

## Features

- Dependency Registration: Register dependencies with the container.
- Dependency Resolution: Resolve dependencies and instantiate objects.
- Constructor Injection: Supports constructor injection for resolving dependencies.
- Flexible Usage: Can be used with various types of classes and interfaces.

## User Management System

This project includes a basic user management system that utilizes the IoC container for dependency injection. It allows for adding and printing users through a console interface, demonstrating the usage of the IoC container.
