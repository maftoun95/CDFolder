using System;
using DbConnection;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // write();
            // read();
            //update();
            delete();

        }

        public static void write(){
            System.Console.WriteLine("enter your first name: ");
            string firstName = System.Console.ReadLine();
            System.Console.WriteLine("enter your last name: ");
            string lastName = System.Console.ReadLine();
            System.Console.WriteLine("hows about a favorite number: ");
            string favoriteNumber = System.Console.ReadLine();
            

            string query = "INSERT INTO users (firstName,lastName,favoriteNumber) VALUES (" + '"' + firstName + '"' + "," + '"' + lastName + '"' + "," + '"' + favoriteNumber + '"' + ");";
            
            System.Console.WriteLine("the query to be run:   "+query);
        }
        public static void read(){
            System.Console.WriteLine("Hey broski. Would you like to read the whole database (enter 1) or read just one column (enter 2)");
            string selection = System.Console.ReadLine();
            if (selection == "1"){
                string query = "SELECT * FROM users";
                System.Console.WriteLine("the query to be run:   "+query);
            } else if (selection == "2"){
                System.Console.WriteLine("Sure, who would you like to know about? Type their first name:");
                string fname = System.Console.ReadLine();

                string query = "SELECT * FROM users WHERE (firstName=" + '"' + fname + '"' + ")";
                System.Console.WriteLine("the query to be run:   "+query);
            } else {
                System.Console.WriteLine("Not a valid response, lets try this again....");
                read();
            }
        }
        public static void update(){
            System.Console.WriteLine("Sounds good, Who would you like to update?? Enter a first name:");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Sure thing, and what column name would you like to update?");
            System.Console.WriteLine("Enter either either firstname, lastName, or favoriteNumber.");
            //the following query stmt needs work
            string query = "UPDATE users SET (firstName=" + '"' + "INPUTvARIABLE" + '"' + ")";
        }
        public static void delete(){
            System.Console.WriteLine("O sad.");
            System.Console.WriteLine("So who\'s getting nixed?");
        }
    }
}