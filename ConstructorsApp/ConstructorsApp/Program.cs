using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Company = "Happy Tails Adoption Center";//this is a constant and can never be changed

            Console.WriteLine("Hello! Welcome to {0}! \n What type of animal are you looking for today?", Company);//the {0} will aprint the sting value of Complay to its spot. 
            string AnimalChoice = Console.ReadLine();//users animal choice
            Console.WriteLine("Great! Now what bread of {0} would you you like?", AnimalChoice);
            var Animal1 = new Animal(AnimalChoice, Console.ReadLine());// this create a new object using var as the data type. var allows to not assign a specific data type and the program will assign whatever type is best for the situation.
                                                                       // Because it's and object from the class Animal it can use the constructor and take in multiple paramaters for values. 
            Console.WriteLine("Great you have chosen a " + Animal1.Breed + " " + Animal1.Type + " As your new pet.");
            Console.ReadLine();
        }
    }
}
