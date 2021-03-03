// Created by: Braxton Fair
// Created on: 03/02/2021

using System;
using System.Collections.Generic;

namespace InterfacesPt2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // polymorphism
            //
            // Butcher
            // Surgeon
            // Barber
            // Director
            //
            // Give ALL classes a method called Cut()
            // put in a list
            // print out the messages
            //
            // a) using inheritance
            // b) using an interface

            Butcher myButcher = new Butcher();
            Surgeon mySurgeon = new Surgeon();
            Barber myBarber = new Barber();
            Director myDirector = new Director();

            List<Cutter> aListOfCutters = new List<Cutter>();

            aListOfCutters.Add(myButcher);
            aListOfCutters.Add(myDirector);
            aListOfCutters.Add(myButcher);
            aListOfCutters.Add(mySurgeon);

            foreach (var cutter in aListOfCutters)
            {
                Console.WriteLine(cutter.Cut());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
