using System;
using DbConnection;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter your first name: ");
            string firstName = System.Console.ReadLine();
            System.Console.WriteLine("enter your last name: ");
            string lastName = System.Console.ReadLine();
            System.Console.WriteLine("hows about a favorite number: ");
            string favoriteNumber = System.Console.ReadLine();
            

            string query = $"INSERT INTO users (firstName,lastName,favoriteNumber) VALUES (" + '"' + firstName + '"' + "," + '"' + lastName + '"' + "," + '"' + favoriteNumber + '"' + ");";
            
            System.Console.WriteLine("the query to be run:   "+query);
        }
    }
}
