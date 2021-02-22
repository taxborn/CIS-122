// Created by: Braxton Fair
// Created on: 01/28/2021
using System;
using System.Collections.Generic;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a couple sweat shirts
            SweatShirt aSweatShirt1 = new SweatShirt(1, 1, "Red", "M", 15.99);
            SweatShirt aSweatShirt2 = new SweatShirt(5, 1, "Blue", "L", 29.99);
            SweatShirt aSweatShirt3 = new SweatShirt(2, 1, "Purple", "L", 29.99);
            SweatShirt aSweatShirt4 = new SweatShirt(4, 2, "Black", "XL", 149.99);
            SweatShirt aSweatShirt5 = new SweatShirt(9, 2, "Red", "XXL", 0.99);
            
            // Create a list to hold all of our sweatshirts and all of them to it
            List<SweatShirt> aListOfSweatShirts = new List<SweatShirt>();

            aListOfSweatShirts.Add(aSweatShirt1);
            aListOfSweatShirts.Add(aSweatShirt2);
            aListOfSweatShirts.Add(aSweatShirt3);
            aListOfSweatShirts.Add(aSweatShirt4);
            aListOfSweatShirts.Add(aSweatShirt5);

            // Our loop to print out all of our sweat shirts
            foreach (var shirt in aListOfSweatShirts)
            {
                Console.WriteLine(shirt.ToString() + "\n\n");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
