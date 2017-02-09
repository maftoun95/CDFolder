using System;

namespace ConsoleApplication
{
    public class Program
    {
        Random rand = new Random();
        public static void Main(string[] args)
        {
                int[] randomNumArr = randomArray();
                
        }
        //random array
        public static int[] randomArray(){
            Random rand = new Random();
            int[] ranray = new int[10];
            for (int i = 0; i < 10; i++){
                ranray[i] = rand.Next(5,25);
            }
            return ranray;
        }
        //coin toss
        public static string tossCoin(){
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int result = rand.Next(0,2);
            if (result == 1){
                System.Console.WriteLine("Heads");
            } else {
                System.Console.WriteLine("Tails");
            }
            return result.ToString();
        }
        public static double tossMultipleCoins(int num){
            double heads = 0.0;
            double tails = 0.0;
            for (int i = 0; i < num; i++){
                
            }
        }
    }
}
