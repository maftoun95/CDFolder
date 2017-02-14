using System;
using DbConnection;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true){
                readAll();
                System.Console.WriteLine("WELCOME to the automated database maintanance system.");
                System.Console.WriteLine("please make a selection from the following: ");
                System.Console.WriteLine("To create a new user, press 1");
                System.Console.WriteLine("To examine the database, press 2");
                System.Console.WriteLine("To change a users information, press 3");
                System.Console.WriteLine("To erase a user, press 4");
                System.Console.WriteLine("To exit, press 5");
                string action = System.Console.ReadLine();
                if (action == "1"){
                    write();
                } else if (action == "2"){
                    read();
                } else if (action == "3"){
                    update();
                } else if (action == "4"){
                    delete();
                } else if (action == "5"){
                    break;
                }
            }
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
            }
        }
        public static void update(){
            System.Console.WriteLine("Sounds good, Here's a look at the database.");
            //print the database
            System.Console.WriteLine("Who would you like to update?? Please enter an id number");
            string idNum = System.Console.ReadLine();
            System.Console.WriteLine("Sure thing, and what column name would you like to update?");
            System.Console.WriteLine("Enter either firstname, lastName, or favoriteNumber.");
            //the following query stmt needs work
            string query = "UPDATE users SET (firstName=" + '"' + "~~~INPUTvARIABLE~~~" + '"' + ")";
        }
        public static void delete(){
            System.Console.WriteLine("O sad.");
            System.Console.WriteLine("So who\'s getting nixed?");
            string whoDem  = System.Console.ReadLine();
            System.Console.WriteLine("Thats cold.... consider it done..");

            string query = "DELETE FROM user WHERE id="+"";
        }
        public static List<Dictionary<string, object>> readAll(){
            list result = DbConnector.ExecuteQuery("SELECT * FROM users");
        }
    }
}