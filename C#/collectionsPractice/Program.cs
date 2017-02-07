using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //Three Basic Arrays
            int[] zeroTo9 = {0,1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < zeroTo9.Length; i++)
            {
            Console.WriteLine(zeroTo9[i]);
            }
            string[] names = {"Tim","Martin","Nikki","Sara"};
            for (int i = 0; i < names.Length; i++)
            {
            Console.WriteLine(names[i]);
            }
            bool[] tF = {true, false, true, false, true, false, true, false, true, false, };
            for (int i = 0; i < tF.Length; i++)
            {
            Console.WriteLine(tF[i]);
            }
        //Multiplication Table
            int[,] timesTable = new int[10,10];
            for (int y = 0; y < 10; y++){
                for (int x = 0; x < 10; x++){
                    timesTable[y,x] = (y + 1) * (x + 1);
                }
            }
            System.Console.WriteLine("timesTable[4,9]: "+timesTable[4,9]); //should write 50
            System.Console.WriteLine("timesTable[0,3]: "+timesTable[0,3]); //should write 4
            System.Console.WriteLine("timesTable[3,7]: "+timesTable[3,7]); //should write 32
            System.Console.WriteLine("timesTable[6,5]: "+timesTable[6,5]); //should write 42
            System.Console.WriteLine("timesTable[8,1]: "+timesTable[8,1]); //should write 18
        //User Info Dictionary
            Dictionary<string,string> person1 = new Dictionary<string,string>();
            person1.Add("name", "Tim");
            person1.Add("favoriteSport", "Futbol");
            person1.Add("petName", "Tuki");
            person1.Add("iceCream", "Yes");
            Dictionary<string,string> person2 = new Dictionary<string,string>();
            person2.Add("name", "Martin");
            person2.Add("favoriteSport", "LAX");
            person2.Add("petName", "Bruno");
            person2.Add("iceCream", "Yes");
            Dictionary<string,string> person3 = new Dictionary<string,string>();
            person3.Add("name", "Nikki");
            person3.Add("favoriteSport", "Hoop Nasty Dunk Dunk");
            person3.Add("petName", "Guanto");
            person3.Add("iceCream", "Yes");
            Dictionary<string,string> person4 = new Dictionary<string,string>();
            person4.Add("name", "Sara");
            person4.Add("favoriteSport", "Tetherball");
            person4.Add("petName", "Maki Roll");
            person4.Add("iceCream", "Yes");
        }
    }
}
