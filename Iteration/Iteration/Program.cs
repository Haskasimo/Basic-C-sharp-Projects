using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //    int[] TestScores = { 98, 99, 85, 70, 34, 91, 90, 94 };

        //for (int i = 0; i < TestScores.Length; i++)// this is a for loop. stating that variable i starts at index 0; if i is less than the Length of the array which in this case is 7, then it triggers the loop again.
        //                                           // i++
        //{

        //    if (TestScores[i] > 85)//this is stating that if the value of the item in the array is 85 or larger then write all indexes that have a value over 85. 
        //    {
        //        Console.WriteLine("Passing test score: " + TestScores[i]);

        //    }

        //}
        //Console.ReadLine();


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        ////iterationg over the list. using for each loop

        //foreach (int score in testScores) //score represents item in list
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score" + score);
        //    }
        //}
        //List<string> names = new List<string>() { "Jessie", "Erik", "Adam", "Daniel" };
        //foreach (string name in names)
        //{

        //        Console.WriteLine(name);

        //}
        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> PassingScores = new List<int>();
        
        foreach (int score in testScores)
        {
            if (score > 85) //this states that is the score is greater than 85 then it will get added to the new list PassingScores. 
            {
                PassingScores.Add(score);
            }
        }
        Console.WriteLine(PassingScores.Count);
        Console.ReadLine();

    }
    }

