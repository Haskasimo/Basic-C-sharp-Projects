using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Good day! \n Can you please tell me what day of the week it is? " );
            string UserAnswer =Console.ReadLine();


            try
            {
                //to comparing user anser to enum first create a variable with data type eum from the DayofWeek Class. then use parse(typeof to compare the userAnswer to the type of enum which is WeekDays. (DayOfWeek.WeekDays) point to the class to use 
                //to make sure there are no typing arrs convert userAnswer to all lowercase. 
                DayOfWeek.WeekDays Today = (DayOfWeek.WeekDays)Enum.Parse(typeof(DayOfWeek.WeekDays), UserAnswer.ToLower());

                Console.WriteLine("Yes today is " + Today);
            }

            catch
            {
                Console.WriteLine("Sorry please that is not the right day");
            }

            










            Console.ReadLine();
          


           
            


        }
    }
}
