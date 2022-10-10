using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to pet finder! Let me help you choose your next pet. \n Please write a number 0-6.");
        int choice1 = Convert.ToInt32(Console.ReadLine());
      
        string[] newPet = { "cat", "dog", "horse", "crocodile", "woolie mammoth", "sugar glider", "barracuda" };
        if (choice1 > 6)
        {
            Console.WriteLine("Sorry, you chose a number that is too high. Please choose a number from 0 to 6.");
        }
        else
        {
            Console.WriteLine("Wonderful! you chose a " + newPet[choice1] + " as your new pet!");
        }
        Console.WriteLine(". \n. \n.");
        Console.WriteLine("Great! now we should pick how many " + newPet[choice1] + "s you want.");
        Console.WriteLine("Pick a number from 0 to 8");
        int choice2 = Convert.ToInt32(Console.ReadLine());

        int[] PetNum = { 10, 6, 33, 2, 6, 50, 24, 100, 1 };
        if (choice2 > 8)
        {
            Console.WriteLine("Sorry, you chose a number that is too high. Please choose a number from 0 to 8.");
        }
        else
        {
            Console.WriteLine("Fantastic! You chose to get " + PetNum[choice2] + " " + newPet[choice1] + "s!");
        }
        Console.WriteLine(". \n. \n.");
        Console.WriteLine("Great! Now what will you feed your pet? \n Choose a number from 0 to 8.");
        int choice3 = Convert.ToInt32(Console.ReadLine());

        List<string> Food = new List<string>();
        Food.Add("salmon");
        Food.Add("skittles");
        Food.Add("pumpkin spiced lattes");
        Food.Add("salami");
        Food.Add("ham sandwiches");
        Food.Add("Your annoying family members");
        Food.Add("super spicy ramen");
        Food.Add("chocolate birthday cake");
        Food.Add("pop rocks");

        Console.WriteLine("Huzzha! You chose to feed " + Food[choice3] + " to your very hungery " + newPet[choice1] + "s!");
        Console.ReadLine();
        }
    }

