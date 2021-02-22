// Created by: Braxton Fair
// Created on: 01/21/2021
using System;
using System.Collections.Generic;

namespace Quiz1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a few wire cutters to play with
            WireCutter aWireCutter1 = new WireCutter("1", "Cutter 1", "Cuts things", 2.50, 1.4);
            WireCutter aWireCutter2 = new WireCutter("2", "SuperCutter3000", "REALLY good cutter", 20.0, 9.51);
            WireCutter aWireCutter3 = new WireCutter("3", "KindaSucky", "Very dull", 1.59, 0.95);
            WireCutter aWireCutter4 = new WireCutter("4", "CopperWireCutter", "Does the job it needs to", 5.50, 9.1);
            WireCutter aWireCutter5 = new WireCutter("5", "SteelWireCutter", "Does the best job", 240.0, 10.1);
            
            // Create a list of 
            List<WireCutter> aListOfWireCutters = new List<WireCutter>();

            aListOfWireCutters.Add(aWireCutter1);
            aListOfWireCutters.Add(aWireCutter2);
            aListOfWireCutters.Add(aWireCutter3);
            aListOfWireCutters.Add(aWireCutter4);
            aListOfWireCutters.Add(aWireCutter5);

            foreach (var cutter in aListOfWireCutters)
            {
                Console.WriteLine(cutter.ToString());
                Console.WriteLine("\n");
            }

            Console.ReadKey(); // So we hang and allow the output to be displayed on the screen
        }
    }
}
