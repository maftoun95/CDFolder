using System;

namespace ConsoleApplication{
    public class Program{
        public static void Main(string[] args){
            //I built this assignment across 2 files to practice calling methods of another class
            Algorithms al = new Algorithms();
            double[] baseCase = {1,3,5,7,9,13};
            double[] negCase = {-1,-3,-5,-7,-9,-13};
            double[] mixCase = {-1,3,5,-7,-9,13};
            al.print1to255();
            al.printOdd();
            al.printSum();
            al.iterating(baseCase);
            al.iterating(negCase);
            al.iterating(mixCase);
            al.findMax(baseCase);
            al.findMax(negCase);
            al.findMax(mixCase);
            al.findAVG(baseCase);
            al.findAVG(negCase);
            al.findAVG(mixCase);
            al.oddray();
            al.greaterThan(baseCase, 3);
            al.square(baseCase);
            al.noNegatives(mixCase);
            al.mMA(baseCase);
            al.shiftee(baseCase);
            al.numString(mixCase);
        }
    }
}
