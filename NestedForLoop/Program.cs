// Created by: Braxton Fair
// Created on: 02/18/2021

using System;
using System.Collections.Generic;

namespace NestedForLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree ourTree = new Tree(4);

            ourTree.CreateTree();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
