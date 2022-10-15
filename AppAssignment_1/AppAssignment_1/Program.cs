using System;
using System.Collections.Generic;



namespace AppAssignment_1
{
    class Program
    {
        static void Main()
        {
            //This block of code is to add to the string value in an array. This will individually target a string and add a string of the users choosing. 
            string[] names = new string[] { "Adam", "Lucy", "Ferris", "Gabrial", "Jem" };

            Console.WriteLine("Hello! Please enter your last name.");
            string LastName = Console.ReadLine();// this create a string from the users input.

            for (int i = 0; i < names.Length; i++)//this itterates through the array starting with index 0 and stopping at the last index, using i<names.Length as a stoping point
            {
                names[i] = names[i] + " " + LastName; //this adds the users input to the array values. to concatinate strings at each index. you need the brackets to target each index individually. If you only put "names" it will cause and error.  

            }
            //this creates a new itteration that checks each indicies and prints the value in the array names[] using name as the item.
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------Part 2------------");
            //this section was creating an infinite loop. Becuse the value of Number always stayed at 4 it will continue to writeLine over and over again. 
            for (int Number = 4; Number < 10; Number++) //added an increment at the end "Number++" so that Number will add 1 to the value of Number so it will eventually equal 10 and therefore make the statement Number < 10 = False and the loop;
            {
                Console.WriteLine("This is the song that never ends, yes it goes on and on my friend!!..");
            }

            Console.WriteLine(".\n.\n.\n.\n.");

            Console.WriteLine("------------Part 3------------");
            //this create a simple loop using < as a true/false statement.
            Console.WriteLine("Let's make a < loop");

            for (int LessThan = 0; LessThan < 5; LessThan++)
            {
                Console.WriteLine("The number is now.." + LessThan);
            }
            Console.WriteLine(".\n.\n.\n.\n.");
            //simalar to the < loop this will check if the value of LessThan is less then oe equal to 16. it will continue to count up to until the value is greater than 16 and will end the loop. 
            Console.WriteLine("Let's make a <= loop \n This will count unitll it reaches 16");

            for (int LessThan = 0; LessThan <= 16; LessThan++)
            {
                Console.WriteLine("The number is now.." + LessThan);
            }
            Console.WriteLine(".\n.\n.\n.\n.");
            Console.WriteLine("------------Part 4------------");


            //this code askes the user to input a fruit, and then checks to see if the useres fruit is included on the list. 
            List<string> fruits = new List<string>() { "apple", "orange", "strawberry", "pear", "watermelon", "dragon fruit", "blackberry", "lemon" };

            Console.WriteLine("I made a list a fruit! \n Type in a fruit to see if it is on my list.");

            string UserChoice = Console.ReadLine();//creating a string variable from user input


            for (int f = 0; f < fruits.Count; f++)//because Lits do not have a defined length, you use .Count insted to iterate through all indicies
            {
                if (fruits[f] == UserChoice) // if the value of UserChoice is the same as somthing in the list, then this will run. 
                {
                    Console.WriteLine("Hey I chose " + UserChoice + " too!");
                    Console.WriteLine("your choice is number " + f);
                }


            }
            //This will run if no match is found
            //write this outside for statement otherwise it will always happen. making a long list of crap!
            if (!fruits.Contains(UserChoice)) //if it does not contain match this will execute.
            {
                Console.WriteLine("Oh sorry I didn't pick that fruit.");
            }


            Console.WriteLine(".\n.\n.\n.\n.");
            Console.WriteLine("------------Part 5------------");

            //This asks the user to input a type of house pet. it will then check to see if that pet is included in a list, and then print out all the indicies it appears in.  
            List<string> Animals = new List<string>() { "cat", "dog", "bird", "dog", "cat", "gerbal", "hampster", "fish", "snake", "lizzard", "dog", "bird", "lizzard", "cat", "rabbit", "snake", "bird", "cat", "gerbal", "hampster", "gerbal", "fish", "dog", "bird", "fish", "bird" };

            Console.WriteLine("Please enter a type of house pet. example:\"dog\", \"cat\" ");
            string AnimalChoice = Console.ReadLine();


            for (int A = 0; A < Animals.Count; A++) //creates a loop to check values at each indicies
            {
                if (Animals[A] == AnimalChoice)//this will trigger if the value at that index matches the value the user input. 
                {

                    Console.WriteLine("your animal appears at index " + A); //This will write "your animal appears at index " and the index it was matched on. 
                }

            }
            //this lies outside the for loop. This will run after all indicies have been checked. 
            if (!Animals.Contains(AnimalChoice)) //If the Animals list does not contain the users input, then this will trigger. ! means not. so this statment is saying Animals does not contain AnimalChoice.
            {
                Console.WriteLine("Your animal is not on my list. ");
            }


            Console.WriteLine(".\n.\n.\n.\n.");
            Console.WriteLine("------------Part 6------------");
            //to check for redundencys, you can create two lists and compare them to see if there are matches.

            List<string> colors = new List<string>() { "blue", "pink", "red", "green", "purple", "red", "black", "yellow" }; //first list of colors with a duplicate of "red" at index 5
            List<string> redudency = new List<string>();//empty list we will be putting colors into

            foreach (string color in colors)
            {
                if (redudency.Contains(color))//this is asking if this list  contains a matching color
                {
                    Console.WriteLine("This color is a duplicate");//if it contains the color, it will write this.
                }
                else
                {
                    Console.WriteLine("This is a unique color!");//if it does not contain that color it will write this 
                }

                redudency.Add(color); //this will add color to the redundency list after it checks everying at that index. When the loop is run again it will notice the duplicate and write the if statement. 
            }



            Console.ReadLine();


            
        }
    }
}
