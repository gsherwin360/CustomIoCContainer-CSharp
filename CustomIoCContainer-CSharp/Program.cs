using CustomIoCContainer_CSharp.Core;
using CustomIoCContainer_CSharp.Implementations;
using CustomIoCContainer_CSharp.Interfaces;

namespace CustomIoCContainer_CSharp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to User Management System!");

        var container = new DependencyContainer();
        container.AddSingleton<IUserManager, UserManager>();
        container.AddTransient<UserController>();

        var resolver = new DependencyResolver(container);
        var userController = resolver.GetService<UserController>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Print Users");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter username to add: ");
                    string usernameToAdd = Console.ReadLine();
                    userController.AddUser(usernameToAdd);
                    Console.WriteLine("User added successfully.");
                    break;
                case 2:
                    Console.WriteLine("List of Users:");
                    userController.PrintUsers();
                    break;
                case 3:
                    Console.WriteLine("\nExiting program... Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}