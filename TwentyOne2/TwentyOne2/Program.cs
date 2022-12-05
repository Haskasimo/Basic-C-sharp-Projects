using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino4;
using Casino4.TwentyOne2;
using System.Data.SqlClient;

namespace TwentyOne2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Welcome to the Glacier Peaks Casino. Let's start by telling me your name.");
            string PlayerName = Console.ReadLine();
            if (PlayerName.ToLower() == "admin")//triggerars a method to list all the information from Table Exceptions in the TwentyOne SQL database
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(); //this will create a list from all the entries under the readExceptions method 
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExcpeptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();

                }
                Console.ReadLine();
                return;//this will end the program. 
            }

            bool validAnswer = false;
            int Bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today? ");
                validAnswer = int.TryParse(Console.ReadLine(), out Bank);//TryParse casts the string to an int. In this section of code its taking the input from the user and converting it to a string and then using the "out" sends it to the variable Bank.
                                                                         //validAnswer is a boolian value, so if the cast is succesful then it will send the converted value to Bank, and then exit the while loop. If it can't be converted, then Bank will be set to 0 and will then trigger the below if statement, and then run the while loop again. 
                                                                         //This while loop will continue to run until the user types a correct amount that can be converted to an intager ans therefore makes validAnswer = true. 
                if (!validAnswer) Console.WriteLine("Please write digets only and no decimals");//this will trigger if there is a failure to cast users input to an int. 

                    }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", PlayerName); //because PlayerName will be added to the Players class, this will take the name enter at index 0. {0} 
            string Answer = Console.ReadLine().ToLower();

            if (Answer == "yes" || Answer == "yeah" || Answer == "y" || Answer == "ya")
            {
                //if user answers in any of the above way, this block of code will trigger. 
                Player player = new Player(PlayerName, Bank); //this is an object created from the constructor for the player class. This initializes it with the begining values of name and beggining money bank.  
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Mara\Documents\Logs\players.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();//polymorphisim is to expose the overloaded operators. 
                game += player;//this adds player to Game class
                player.isActiveltPlaying = true; //property of the player class which means while the player is playing, continue as well

                //using a while loop it can keep the loop running while certain conditions are happening. but while loops can be problematic. 
                while (player.isActiveltPlaying && player.Balance > 0)//if these two conditions are met (is the player still activly play, and does the player still have money in the bank) theloop will keep going.  
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);//calling Update DB method to send the Eception error to the Database
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("If error occured please contact you system administratior.");
                        UpdateDbWithException(ex);//calling method To update the data base with This eception error.
                        Console.ReadLine();
                        return;//if the exception is made, then this will exit the program. 
                    }
                    
                }
                game -= player;//if the while conditions are no longer mwt, it will take the player out of the game class, and play this message. 
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");//If the User answers No instead of Yes when asked to play, it will not load the player into the game and not start the game while loop. This mesage will trigger instead.  
            Console.ReadLine();




        }
        //connection to a SQL database to log exception info and time.
        private static void UpdateDbWithException(Exception ex)
        {   
            //We want Connection string to be the connection information to the dtabase. we find this by opening up SQL Server Object Explorer, right click our Database and select properties. 
            //in the property table copy and past the information nect to connection string to the value of ConnectionString. 
            string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //This sests of the format to be able to make a query to the database.
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //opens up a connection to the SQL server and sets up the paramaters and values to send to the database. 
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               //setting up paramaters (what part of the table and what type of data is to be stored.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);

                //setting up values to be sent to the paramaters
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();//the .getType will get the type of data of the Exception, and then converts it to string format using .ToString. 
                command.Parameters["@ExceptionMessage"].Value = ex.Message;//this will send the exception message to the @ExceptionMessage paramater
                command.Parameters["@TimeStamp"].Value = DateTime.Now;//This will send the current day and time information and assign it as the value of @TimeStamp

                //Send to database
                connection.Open();//opening up the connecton to the SQL server
                command.ExecuteNonQuery();//because we are inserting information we select a nonQuery. This will insert information
                connection.Close();//Clses connection to the SQL Server

            }
        }
        private static List<ExceptionEntity> ReadExceptions()//this will create a method that connects to the database and 
        {
            string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, Timestamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();//creating new list opject that entitys recived from the Database query can be inserted into. 
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))//opening up a connection to the database by passing in the ConnectionString as its paramater. 
            {
                SqlCommand command = new SqlCommand(queryString, connection);//created a command for a query
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())//loops through each record that you get back from your query
                {
                    ExceptionEntity exception = new ExceptionEntity();//creates a new object for each entity recived from the reader.
                    exception.Id = Convert.ToInt32(reader["Id"]); //reader[id] maps to the collumn id field in the database but information will be in SQL format. We have to convert it to C# language for each query. 
                    exception.ExcpeptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);//each loop through the reader will add the newely created exception object to the list Exceptions/ 

                }
                connection.Close();

            }
            return Exceptions;

        }

    }

}

