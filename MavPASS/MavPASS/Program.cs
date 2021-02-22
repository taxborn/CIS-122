// Created by Braxton Fair
// Created on: 01/21/2021

using System;
using System.Collections.Generic;

namespace MavPASS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pen aPen1 = new Pen("Purple", "Ballpoint", 20);
            Pen aPen2 = new Pen("Blue", "Ballpoint", 25);
            Pen aPen3 = new Pen("Black", "Ballpoint", 30);
        
            List<Pen> aListOfPens = new List<Pen>();

            aListOfPens.Add(aPen1);
            aListOfPens.Add(aPen2);
            aListOfPens.Add(aPen3);

            foreach (var pen in aListOfPens)
            {
                Console.WriteLine(pen.ToString());
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        } 
    }
}
