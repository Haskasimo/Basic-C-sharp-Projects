using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstProject
{
    class Program
    {


        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //create and save new stundent info
                Console.WriteLine("Enter Students full name:  ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Students Age.");
                var age = Console.ReadLine();
                Console.WriteLine("Enter Students GPA. ");
                var gpa = Console.ReadLine();
                Console.WriteLine("Enter Guardian's Contact number. ");
                var contact = Console.ReadLine();

                var student = new Student { Name = name, Age = age, GPA = gpa, GuardianContact = contact };
                db.Students.Add(student);
                db.SaveChanges();

                //Display enrolled students
                var query = from s in db.Students
                            orderby s.Name
                            select s;
                Console.WriteLine("Enrolled Students : ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name + " | " + item.Age + " | " + item.GPA + " | " + item.GuardianContact);
                }
                Console.WriteLine("Press any key to exit....");
                Console.ReadLine();
            }

        }
    }
        public class Student
        { 
         public int StudentId { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            public string GPA { get; set; }
            public string GuardianContact { get; set; }
            public virtual List<Student> Students { get; set; }
        }

            
        

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

        
    
}
