// Created by: Braxton Fair
// Created on: 02/25/2021

using System;

namespace InterfaceExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Eagle anEagle1 = new Eagle();
            Eagle anEagle2 = new Eagle();
            Eagle anEagle3 = new Eagle();
            Seagull aSeagull1 = new Seagull();
            Seagull aSeagull2 = new Seagull();
            Seagull aSeagull3 = new Seagull();
            Seagull aSeagull4 = new Seagull();

            List<Flyable> aListOfFlyingBirds = new List<Flyable>();
            List<Swimable> aListOfSwimmingBirds = new List<Swimable>();

            aListOfFlyingBirds.Add(anEagle1);
            aListOfFlyingBirds.Add(anEagle2);
            aListOfFlyingBirds.Add(anEagle3);
            aListOfFlyingBirds.Add(aSeagull1);
            aListOfFlyingBirds.Add(aSeagull2);
            aListOfFlyingBirds.Add(aSeagull3);
            aListOfFlyingBirds.Add(aSeagull4);


            Console.WriteLine("Press any key to continue...");
        }
    }
}
