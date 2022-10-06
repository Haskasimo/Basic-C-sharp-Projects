using System;


namespace SimpleMath
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's add 15 to 45!");
            int Add1 = 15;
            int Add2 = 45;
            int total = Add1 + Add2;
            Console.WriteLine(total);
            //subtraction
            Console.WriteLine("Let's subtract 35 from 237.");
            int Sub1 = 237;
            int Sub2 = 35;
            int difference = Sub1 - Sub2;
            Console.WriteLine(difference);
            //multiply
            Console.WriteLine("Let's multiply 8 and 74.");
            int mult1 = 8;
            int mult2 = 74;
            int product = mult1 * mult2;
            Console.WriteLine(product);
            //division
            Console.WriteLine("Let's divide 45 by 5");
            int div1 = 45;
            int div2 = 5;
            int quotient = div1 / div2;
            Console.WriteLine(quotient);
            Console.ReadLine();
        }
    }
}
