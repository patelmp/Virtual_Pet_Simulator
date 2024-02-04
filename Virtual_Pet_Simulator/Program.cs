using System;
using System.Collections.Generic;
using Random = System.Random;


public class Pet
// Here using Get and set method to check multiple codition 
{
    public string Type { get; }
    public string Name { get; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public Pet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 10;
        Happiness = 10;
        Health = 10;
    }



    public void Feed()
    {
        Hunger--;
        Health++;
        Console.WriteLine($"You feed {Name}. His hunger decreases, and health improves slightly.");
    }

    public void Play()
    {
        if (Happiness <= 2)
        {
            Console.WriteLine($"{Name} is too unhappy to play. Try feeding them or resting them.");
            return;
        }

        Happiness--;
        Hunger++;
        Console.WriteLine($"You played with {Name}.His happiness increases, but he's a bit hungry.");
    }

    public void Rest()
    {
        Happiness--;
        Health++;
        Console.WriteLine($"{Name} is now more healthy!");
    }

    public void CheckStatus()
    {
        Console.WriteLine($"{Name}'s stats:");
        Console.WriteLine($"- Hunger : {Hunger}");
        Console.WriteLine($"- Happiness : {Happiness}");
        Console.WriteLine($"- Health : {Health}");

        if (Hunger <= 2)
        {
            Console.WriteLine($"{Name} is very hungry! Feed them soon.");
        }
        else if (Happiness >= 8)
        {
            Console.WriteLine($"{Name} is very happy! They might need a break.");
        }

        if (Health <= 2)
        {
            Console.WriteLine($"{Name} is very sick! Take them to the vet!");
        }
        else if (Health >= 8)
        {
            Console.WriteLine($"{Name} is in great health!");
        }
    }

    public void TimePass()
    {
        Hunger++;
        Happiness--;

        if (new Random().NextDouble() < 0.1)
        {
            Health--;
            Console.WriteLine($"{Name} got sick! Their health is now {Health}.");
        }
    }
}

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
        string petType = "";
        //Using If else condition so user can select any one of the pet.
        if (choice == 1)
        {
            petType = "Cat";
        }
        else if (choice == 2)
        {
            petType = "Dog";
        }
        else if (choice == 3)
        {
            petType = "Rabbit";
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
        // Defining pet Menu catagory

        var pet = new Pet(petType, petName);

        var actions = new Dictionary<string, Action>
        {
            ["1"] = pet.Feed,
            ["2"] = pet.Play,
            ["3"] = pet.Rest,
            ["4"] = pet.CheckStatus,
            ["5"] = pet.TimePass,
            ["6"] = () => Environment.Exit(0)
        };
        // using while loop if top codition is true.
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Feed " + petName);
            Console.WriteLine("2. Play With " + petName);
            Console.WriteLine("3. Let " + petName + " Rest");
            Console.WriteLine("4. Check " + petName + "'s Status");
            Console.WriteLine("5. Time Pass With " + petName);
            Console.WriteLine("6. Exit");
            Console.Write("User InPut : ");
            string action = Console.ReadLine();
            //Using If else condition to check action or main menu
            if (actions.ContainsKey(action))
            {
                actions[action]();
            }
            else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }
}