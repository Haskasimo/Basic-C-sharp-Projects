using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsIntagersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int>() { 400, 590, 2460, 7525, 2267, 140, 89, 1003 };

                Console.WriteLine("Please enter a whole number.");
                int UserNumber = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Numbers.Count; i++)
                {
                    Numbers[i] = Numbers[i] / UserNumber;
                }

                foreach (int number in Numbers)
                {
                    Console.WriteLine("my number divided by " + UserNumber + " equals " + number);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Apologies good Sir or Madam...Please enter a whole number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("By golly gee! I can't divide by zero! Please enter a number that is NOT Zero.");
            }
            catch(Exception)
            {
                Console.WriteLine("I don't know what you did...but you screwed up, please enter again.");
            }
            finally
            {
                Console.WriteLine("If you would like to try again..Please restart the program...If not we can continue.");
                Console.ReadLine();
            }
            
        }
    }
}
