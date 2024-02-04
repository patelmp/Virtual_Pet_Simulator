using System;
public static class Program
{
    private static readonly string name;

    public static void Main()
    {
        Console.WriteLine("Please Choose a type pet:");
        Console.WriteLine("1. Cat");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3. Rabbit");
        Console.WriteLine("Enter your choice from given list from 1, 2, or 3. ");
        Console.Write("User InPut : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Using If else condition so user can select any one of the pet.
        if (choice == 1)
        {
        }
        else if (choice == 2)
        {
        }
        else if (choice == 3)
        {
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose from 1, 2, or 3.");
            return;
        }
        Console.WriteLine("You’ve chosen a " + petType + ". What would you like to name your pet?.");
        Console.Write("User InPut : ");

        string petName = Console.ReadLine();
        Console.WriteLine("Welcome, " + petName + "! Lets take good care of him.");

        var pet = new Pet(petType, petName);

    }
}