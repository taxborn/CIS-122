// Created by: Braxton Fair
// Created on: 02/22/2021

using System;
using System.Collections.Generic;

namespace InheritancePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a couple of each class
            Teacher burke = new Teacher("teacher", false, "MSU", 45);
            Teacher aiden = new Teacher("teacher", true, "MSU", 7);

            Farmer cornFarmer = new Farmer("farmer", false, "Iowa", "Corn");
            Farmer soyBeanFarmer = new Farmer("farmer", false, "Minnesota", "Soy Beans");

            RetailWorker braxton = new RetailWorker("worker", false, "Albertville", "Crocs");
            RetailWorker luke = new RetailWorker("worker", true, "Rogers", "Target");

            // Create a list to hold each classes objects
            List<Teacher> aRosterOfTeachers = new List<Teacher>();
            List<Farmer> aRosterOfFarmers = new List<Farmer>();
            List<RetailWorker> aRosterOfRetailWorkers = new List<RetailWorker>();

            // Add our classes to the list
            aRosterOfTeachers.Add(burke);
            aRosterOfTeachers.Add(aiden);

            aRosterOfFarmers.Add(cornFarmer);
            aRosterOfFarmers.Add(soyBeanFarmer);

            aRosterOfRetailWorkers.Add(braxton);
            aRosterOfRetailWorkers.Add(luke);

            // We can create a generic list that can hold each class, since they all inherit Job, we can create a List of type Job
            List<Job> ourListOfJobs = new List<Job>();

            // Add each to the list
            ourListOfJobs.Add(burke);
            ourListOfJobs.Add(aiden);
            ourListOfJobs.Add(cornFarmer);
            ourListOfJobs.Add(soyBeanFarmer);
            ourListOfJobs.Add(braxton);
            ourListOfJobs.Add(luke);
    
            // Loop over each list and display the classes contents
            foreach (var teacher in aRosterOfTeachers)
            {
                Console.WriteLine(teacher.ToString() + "\n");
            }

            Console.WriteLine("-----\n");

            foreach (var farmer in aRosterOfFarmers)
            {
                Console.WriteLine(farmer.ToString() + "\n");
            }

            Console.WriteLine("-----\n");

            foreach (var worker in aRosterOfRetailWorkers)
            {
                Console.WriteLine(worker.ToString() + "\n");
            }

            Console.WriteLine("-----\n");

            // Looping over a generic list will be the same
            foreach (var worker in ourListOfJobs)
            {
                Console.WriteLine(worker.ToString() + "\n");
            } 

            // Hang until the user has viewed the input
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
