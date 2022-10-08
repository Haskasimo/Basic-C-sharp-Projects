using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Can You Drive Car Insurance. \n Please answer this questionaire to see if you qualify for insurance.");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            //checking to see if driver is at correct age
            Console.WriteLine("Question 1... Please enter your age");
            string UserAge = Console.ReadLine();
            int AgeCheck = Convert.ToInt32(UserAge);
            bool Age = AgeCheck > 15;
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            //question 2 DUI check
            Console.WriteLine("Question 2... Have you ever had a DUI? Please answer yes or no.");
            string DUICheck = Console.ReadLine();
            bool DUI = DUICheck == "no";
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            //question 3 Speeding tickets.
            Console.WriteLine("Question 3... How many speeding tickets do you have? please enter number only. example: 2");
            string UserTicket = Console.ReadLine();
            int TicketCheck = Convert.ToInt32(UserTicket);
            bool Ticket = TicketCheck < 4;
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("Thank you... Here is your qualification information :");
            Console.WriteLine("Your current age.");
            Console.WriteLine(AgeCheck);
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(DUICheck);
            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine(TicketCheck);
            Console.WriteLine("Qualified:");
            bool Qualified = (Age && DUI && Ticket);//this checks if all variables eqal true. if even one is false it will return false.
            Console.WriteLine(Qualified);
            Console.ReadLine();





        }
    }
}
