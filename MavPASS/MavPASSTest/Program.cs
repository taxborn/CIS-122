// Created by: Braxton Fair
// Created on: 02/15/2021

using System;
using System.Collections.Generic;

namespace MavPASSTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Month> aListOfMonths = new List<Month)();

            Month january = new Month(4);
            Month february = new Month(4);
            Month march = new Month(5);

            aListOfMonths.Add(january);
            aListOfMonths.Add(february);
            aListOfMonths.Add(march);

            foreach (var month in aListOfMonths)
            {
                Console.WriteLine(month.ToString());
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
