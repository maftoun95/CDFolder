using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<object> ting = new List<object>();
            ting.Add(7);
            ting.Add(28);
            ting.Add(-1);
            ting.Add(true);
            ting.Add("chair");
            int sum = 0;
            for (int i = 0; i < ting.Count; i++) 
            {
                if (ting[i] is int)
                {
                    sum += (int)ting[i];
                }
                System.Console.WriteLine(ting[i]);
            }
            System.Console.WriteLine(sum);
        }
    }
}
