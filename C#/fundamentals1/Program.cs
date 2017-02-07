using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // oneto255();
            // threeOrFive();
            // fizzBuzz();
            fizzBuzzALT();
        }
        public static void oneto255()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void threeOrFive()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void fizzBuzz()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
        }
        public static void fizzBuzzALT()
        {
            for (var i = 1; i <= 1000; i++)
            {
                if ((float)i / (float)3 == 0 && (float)i / (float)5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if((float)i / (float)5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if ((float)i / (float)3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
        }
    }
}
