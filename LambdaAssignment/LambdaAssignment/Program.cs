using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Program
    {
        public static void Main(string[] args)

          
            
        {
            List<Employee> AllEmployees = new List<Employee>()//creating new empty list from the Employee class.
            {
                //Because we already made the variable Employee. we just need to assign values to it. so instead of <Employee> Employee = new Employee, we just need (new Employee) and the values from the propertied in the Employee class  
             new Employee(){Id= 201, FirstName= "Beth", LastName= "Parker"},
             new Employee(){Id= 202, FirstName= "Joe", LastName= "Smith"},
             new Employee(){Id= 203, FirstName= "Amy", LastName= "Tundry"},
             new Employee(){Id= 204, FirstName= "Joe", LastName= "Boom"},
             new Employee(){Id= 205, FirstName= "Amelia", LastName= "Baxter"},
             new Employee(){Id= 206, FirstName= "Sujin", LastName= "Park"},
             new Employee(){Id= 207, FirstName= "Kiara", LastName= "Bond"},
             new Employee(){Id= 208, FirstName= "Lilly", LastName= "Finly"},
             new Employee(){Id= 209, FirstName= "Joe", LastName= "Hills"},
             new Employee(){Id= 210, FirstName= "Erik", LastName= "Sooter"},
            };

            foreach (Employee employees in AllEmployees)//this foreach loop iterates each item in the list AllEmployees 
            {
                if (employees.FirstName == "Joe")//This checks if the property FirstName in each iteration and if it is equal to Joe. It will trigger the Console.WriteLine
                {
                    Console.WriteLine(employees.Id + " " + employees.FirstName + " " + employees.LastName);//Now we need to make sure the console knows which properties we want displayed for each itteration. 
                }
            }
            
            
            
            //This is the Lambda Expression for .Where. .Where will check items in a list for a specific constriants and if those constraints are met it will create a new list. 

            //in this line of code we want to check to see if any of the items in the list have the property FirstName and it is equal to "Joe"
            //First we create a new list with type <Employee> and name it Joe. Then we refence The Main List AllEmployees and add the .Where(x =>)  method. and list our constraints that we are looking for the isem with porperty FirstName that is equal to "Joe". because there are multiple items we need to send ot to the list by yping .ToList().  
           List<Employee> Joe = AllEmployees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employees in Joe)//this will itterate through the list Joe and for each itteration will Write to the Console. You need to specify what information (properties) you want displayed. 
            {
                Console.WriteLine(employees.Id + " " + employees.FirstName + " " + employees.LastName);
            }

            List<Employee> JoeId = AllEmployees.Where(x => x.Id > 205).ToList();//This is the same Lambda Expression but instead of searching for Firstname as our constraint, we are targeting the Id and using the comparison > 
            foreach (Employee employees in JoeId)//this will then itterate through the list JoeId and print them to the console. 
            {
                Console.WriteLine(employees.Id + " " + employees.FirstName + " " + employees.LastName);
            }

            Console.ReadLine();

            
            
           



           
               
            






           
    }
    }
}
