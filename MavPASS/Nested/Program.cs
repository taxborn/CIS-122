// Created By: CIS-122 MavPass
// Created on: 02/18/2021

using System;

namespace Nested
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree ourTree = new Tree(10);

            Console.WriteLine(ourTree.ToString());

            // Hang until the user views the output
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
