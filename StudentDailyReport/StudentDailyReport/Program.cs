using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {   //program welcom message
            Console.WriteLine("The Tech Academy \n Student Daily Reoprt ");
            //first question
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine(); // this makes a string variable "myName" with the value of the string the user typed in the privius line
            //second question
            Console.WriteLine("What course are you on?");
            string myCourse = Console.ReadLine();
            //third question
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int PageN = Convert.ToInt32(pageNumber);//incase this number needs to be added or subtracted later on, such as adding pages to the current page count, this changes the data type to an intager instead of a string.
            //fourth question
            Console.WriteLine("Do you needhelp with anything? \n Please answer \"true\" or \"false\"");//adding "" will end the string. in order to print quatations add ing a backslash pefore each quatation will ensure it will print the quatations and not end the string.
            string helpMe = Console.ReadLine();
            bool helpAnswer = Convert.ToBoolean(helpMe);//the programmer might want to trigger an additional mesage depending on the answer, so converting the data from a string to a bool will be easier to work with. this can be dangerous because if the user incorrectly types  their answer it will result in an error. 
            //Fifth question
            Console.WriteLine("were there are positive ecpirences you'd like to share? Please be specific ");
            string GoodExp = Console.ReadLine();
            //sixth question
            Console.WriteLine("How many hours did you study today?Please give numeric value only.");
            string StudyHours = Console.ReadLine();
            int Hours = Convert.ToInt32(StudyHours);//the programmer might need to adjust hours through math at a later date, so this data type will need to change to an integer as you can not do math operations on a string.
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();//this ensures that the console does not close on it's own, and gives the user time to read the final mesage before they manualy close it themselves. 







        }
    }
}
