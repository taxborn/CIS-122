// Created by: Braxton Fair
// Created on: 02/16/2021

using System;
using System.Collections.Generic;

namespace TestPart1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a couple of SmartPhones
            SmartPhone aPhone1 = new SmartPhone(true, true, "ARM", 4.00f);
            SmartPhone aPhone2 = new SmartPhone(true, false, "Intel", 1.00f);
            SmartPhone aPhone3 = new SmartPhone(false, true, "Intel", 2.00f);
            SmartPhone aPhone4 = new SmartPhone(false, false, "RISC-V", 2.00f);
            SmartPhone aPhone5 = new SmartPhone(true, true, "AMD", 6.00f);

            // Create a list to hold our smartphones
            List<SmartPhone> aPackageOfPhones = new List<SmartPhone>();

            // Add our smart phones to our list
            aPackageOfPhones.Add(aPhone1);
            aPackageOfPhones.Add(aPhone2);
            aPackageOfPhones.Add(aPhone3);
            aPackageOfPhones.Add(aPhone4);
            aPackageOfPhones.Add(aPhone5);

            // loop through our list and use ToString to print data from our phones
            foreach (var phone in aPackageOfPhones)
            {
                Console.WriteLine(phone.ToString() + "\n");
            }

            // Hang so we can see the output
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
