using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly wage.");//user will type wage and we will store it in the hourWage variable.
            string HourW1 = Console.ReadLine();
            int hourWage = Convert.ToInt32(HourW1);
            Console.WriteLine("Please enter your hours worked per week.");
            string WeekW1 = Console.ReadLine();
            int weekWork = Convert.ToInt32(WeekW1);
            int Product1 = hourWage * weekWork;
            int yearWage_1 = Product1 * 52;

            

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly wage.");
            string HourW2 = Console.ReadLine();
            int hourWage_2 = Convert.ToInt32(HourW2);
            Console.WriteLine("Please enter your hours worked per week.");
            string WeekW2 = Console.ReadLine();
            int weekWork_2 = Convert.ToInt32(WeekW2);
            int Product_2 = hourWage_2 * weekWork_2;
            int yearWage_2 = Product_2 * 52;

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Person 1's yearly salary is.....$" + yearWage_1);

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Person 2's yearly salary is.....$" + yearWage_2);


            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            Console.WriteLine("Does Person 1 make more money that Person 2? ");
            bool WhoMakesMore = yearWage_1 > yearWage_2;
            Console.WriteLine(WhoMakesMore);

            Console.ReadLine();


        


        }
    }
}
