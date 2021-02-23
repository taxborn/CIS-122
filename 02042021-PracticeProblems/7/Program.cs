// Created by: Braxton Fair
// Created on: 02/23/2021

using System;

namespace _7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create some example arrays
            int[] anArray1 = { 1, 1, 0, 1, 3, 10, 10, 10, 10,   1 };
            int[] anArray2 = { 0, 0, 0, 0, 0,  0,  0,  0,  0, 100 };
            int[] anArray3 = { 1, 2, 3, 4, 5,  6,  7,  8,  9,  10 }; 
                
            // Pass our arrays into our Summator
            Summator maxSum1 = new Summator(anArray1);
            Summator maxSum2 = new Summator(anArray2);
            Summator maxSum3 = new Summator(anArray3);

            // Print out all of our values
            Console.WriteLine("Calculate the sum of the three largest values in an array.\n");

            Console.WriteLine("anArray1 = " + maxSum1.CalculateMax(3));
            Console.WriteLine("anArray2 = " + maxSum2.CalculateMax(3));
            Console.WriteLine("anArray3 = " + maxSum3.CalculateMax(3));

            // Hang until the user views the output
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
