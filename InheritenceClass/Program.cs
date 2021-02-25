// Created by: Braxton Fair
// Created on: 02/23/2021

using System;
using System.Collections.Generic;

namespace InheritenceClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of birds
            List<Bird> aListOfBirds = new List<Bird>();

            Eagle myEagle = new Eagle("Stanford");
            Penguin myPenguin = new Penguin("Happy Feet");
            Ostrich myOstrich = new Ostrich("Tango");
            Seagull mySeagull = new Seagull();
            Duck myDuck = new Duck("Quack");
            HummingBird myHummingBird = new HummingBird("Bizz");

            aListOfBirds.Add(myEagle);
            aListOfBirds.Add(myPenguin);
            aListOfBirds.Add(myOstrich);
            aListOfBirds.Add(mySeagull);
            aListOfBirds.Add(myDuck);
            aListOfBirds.Add(myHummingBird);

            foreach (var bird in aListOfBirds)
            {
                Console.WriteLine(bird.ToString());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
