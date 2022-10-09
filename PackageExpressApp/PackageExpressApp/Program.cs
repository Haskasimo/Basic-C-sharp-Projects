using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n Please write the weight of your package. ");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("please enter the width of your package in inches");
                int Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the Height of your package in inches");
                int Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of your package in inches");
                int Length = Convert.ToInt32(Console.ReadLine());
                if (Width + Height + Length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int ShippingCost = (Width * Height * Length) * Weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:$" + ShippingCost +".00");
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

            }

        }
    }
}
