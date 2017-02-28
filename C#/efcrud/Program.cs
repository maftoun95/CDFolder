using System;
using System.Linq;
using efcrud.Models;

namespace efcrud
{

    public class Program
    {

        public static void Main()
        {

            //using codeblock so the db connection gets canned after execution.
            using(var db = new StudentContext())
            {

                Console.WriteLine("Welcome to the console CRUD app!");
                string choice = "";
                //choice is instantiated so we can run a while loop that keeps going untill the user types exit
                while(choice != "exit")
                {
                    Console.WriteLine("Would you like to 'create', 'read', 'readall', 'update', or 'destroy'? ('exit' to leave)");
                    //prompt options. choice is compared to a switch statement
                    choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "create":
                            Create(db);
                            break;
                        case "read":
                            Show(db);
                            break;
                        case "readall":
                            Index(db);
                            break;
                        case "update":
                            Update(db);
                            break;
                        case "destroy":
                            Destroy(db);
                            break;
                        case "exit":
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Not a valid command");
                            break;
                    }
                }
            //preceding while loop will continue to call predefined functions untill exit command is given
            }
        }

        //Create an instance of Student in the db
        public static void Create(StudentContext db)
        {
            Console.WriteLine("Let's make a new student!");
            Console.Write("Student's first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Student's last name: ");
            string LastName = Console.ReadLine();
            Console.Write("Student's Age: ");
            string Age = Console.ReadLine();
            //after collecting the required fields for our SQL statement, use try/catch in case the provided values are screwy.
            try
            {
                //turn string into int
                int StudentAge = int.Parse(Age);
                // pop the provided values into a new person
                Person NewStudent = new Person { FirstName = FirstName, LastName = LastName, Age = StudentAge}; 
                // Add and Save
                db.Add(NewStudent);
                db.SaveChanges();
            }
            catch
            {
                //dont freak out
                System.Console.WriteLine("Things didn't go according to plan, lets start from the top..");
            }
        }

        //Read a db row
        public static void Show(StudentContext db)
        {
            Console.WriteLine("What is the ID of the student you would like to see?");
            string idInput = Console.ReadLine();
            try
            {
                // string ----> int
                int studentId = int.Parse(idInput);
                //fetch student by id
                Person TheStudent = db.Students.SingleOrDefault(student => student.PersonID == studentId);
                //log results
                Console.WriteLine($"{TheStudent.FirstName} {TheStudent.LastName}");
                Console.WriteLine($"Age: {TheStudent.Age}");
            }
            catch
            {
                // dont freak out
                Console.WriteLine("I couldn't find that student");
            }
        }

        // show the whole db
        public static void Index(StudentContext db)
        {
            // print all students
            foreach(Person student in db.Students)
            {
                Console.WriteLine($"{student.PersonID}: {student.FirstName} {student.LastName}, Age: {student.Age}");
            }
        }

        // update fields
        public static void Update(StudentContext db)
        {
            Console.WriteLine("What is the ID of the student you would like to update?");
            string idInput = Console.ReadLine();
            // try/catch:
            try
            {
                int studentId = int.Parse(idInput);
                Person TheStudent = db.Students.SingleOrDefault(student => student.PersonID == studentId);
                Console.Write("Student's new first name: ");
                string FirstName = Console.ReadLine();
                Console.Write("Student's new last name: ");
                string LastName = Console.ReadLine();
                Console.Write("Student's new age: ");
                string Age = Console.ReadLine();
                int StudentAge = int.Parse(Age);
                // make updates
                TheStudent.FirstName = FirstName;
                TheStudent.LastName = LastName;
                TheStudent.Age = StudentAge;
                // save updates
                db.SaveChanges();
            }
            catch
            {
                // dont freak out
                Console.WriteLine("I couldn't find that student");
            }
        }

        // Delete a student from db
        public static void Destroy(StudentContext db)
        {
            Console.WriteLine("What is the ID of the student you would like to delete?");
            string idInput = Console.ReadLine();
            try
            {
                //grab the student instance
                int studentId = int.Parse(idInput);
                Person TheStudent = db.Students.SingleOrDefault(student => student.PersonID == studentId);
                // Remove the Student's record
                db.Students.Remove(TheStudent);
                // Save the removal
                db.SaveChanges();
                Console.WriteLine($"{TheStudent.FirstName} {TheStudent.LastName} has been deleted");
            }
            catch
            {
                // dont freak out
                Console.WriteLine("I couldn't find that student");
            }
        }
    }
}