// Created by: Braxton Fair
// Created on: 02/16/2021

using System;
using System.Collections.Generic;

namespace TestPart3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the user input
            Console.WriteLine("What letter do you want to use?");
            string letter = Console.ReadLine();

            Console.WriteLine("\nWhat is the starting number?");
            int starting = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhat is the ending number?");
            int ending = Convert.ToInt32(Console.ReadLine());

            // Create our message
            Message ourMessage = new Message(letter, starting, ending);

            // Use our CreateMessage method to return our string
            Console.WriteLine(ourMessage.CreateMessage());
            
            // Hang until user can evaluate the output
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
