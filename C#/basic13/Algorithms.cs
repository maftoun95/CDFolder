using System;
using System.Collections.Generic;

namespace ConsoleApplication{
    public class Algorithms{
        public void print1to255(){
            for (int i = 1; i <= 255; i++){
                System.Console.WriteLine(i);
            }
        }
        public void printOdd(){
            for (int i = 1; i <= 255; i+=2){
                System.Console.WriteLine(i);
            }
        }
        public void printSum(){
            int sum = 0;
            for (int i = 1; i <= 255; i++){
                sum += i;
                System.Console.WriteLine("New number: {0} Sum: {1}", i , sum );
            }
        }
        public void iterating(Array arr){
            if (arr.Length > 0){
                foreach (int val in arr){
                    System.Console.WriteLine(val);
                }
            }
        }
        public void findMax(double[] arr){
            if (arr.Length > 0){
                double max = arr[0];
                foreach (int val in arr){
                    if (max < val){
                        max = val;
                    }
                }
                System.Console.WriteLine(max);
            }
        }
        public void findAVG(double[] arr){
            if (arr.Length > 0){
                double sum = 0;
                double len = arr.Length;
                foreach (double val in arr){
                    sum += val;
                }
                System.Console.WriteLine("avg is {0}",(sum/len));
            }
        }
        public void oddray(){
            double[] y = new double[256/2];
            int j = 0;
            for (int i = 1; i <= 255; i+=2){
                y[j] = i;
                j++;
            }
            for (int i = 0; 1 < y.Length; i++){
                System.Console.WriteLine("position {0} is {1}", i, y[i]);
            }
        }
        public void greaterThan(double[]arr, int y){
            int count = 0;
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] > y){
                    count++;
                }
            }
            System.Console.WriteLine("the number of elements greater than y is {0}",count);
        }
        public void square(double[] arr){
            for (int i = 0; i < arr.Length; i++){
                arr[i] *= arr[i];
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine("position {0} is {1}", i, arr[i]);
            }
        }
        public void noNegatives(double[]arr){
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    arr[i] = 0;
                }
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine("position {0} is {1}", i, arr[i]);
            }
        }
        public void mMA(double[]arr){
            double min = arr[0];
            double max = arr[0];
            double sum = 0;
            double len = arr.Length;
            for (int i = 0; i < arr.Length; i++){
                if (min > arr[i]){
                    min = arr[i];
                }
                if (max < arr[i]){
                    max = arr[i];
                }
                sum += arr[i];
            }
            System.Console.WriteLine($"min is {min}");
            System.Console.WriteLine($"max is {max}");
            System.Console.WriteLine($"avg is {sum/len}");
        }
        public void shiftee(double[]arr){
            for (int i = 0; i < arr.Length; i++){
                if (i == arr.Length-1){
                    arr[i] = 0;
                } else {
                    arr[i] = arr[i+1];
                }
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine($"Post shift, position {i} is {arr[i]}");
            }
        }
        public void numString(double[]arr){
            List<object> result = new List<object>();
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    result.Add("Dojo");
                } else {
                    result.Add(arr[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine($"Post stringification, position {i} is {result[i]}");
            }
        }
    }
}
