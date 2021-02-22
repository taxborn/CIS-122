// Created by: Braxton Fair
// Created on: 02/16/2021

using System;
using System.Collections.Generic;

namespace TestPart2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a couple reviews
            CustomerReview aReview1 = new CustomerReview(4, "Good", "02/12/2021", "John");
            CustomerReview aReview2 = new CustomerReview(1, "Terrible", "02/11/2020", "John");
            CustomerReview aReview3 = new CustomerReview(2, "Worst product ever", "02/15/2021", "John");
            CustomerReview aReview4 = new CustomerReview(5, "Great", "02/12/2021", "Barry");
            CustomerReview aReview5 = new CustomerReview(5, "best purcase", "02/10/2021", "Barry");

            // Create a list of reviews
            List<CustomerReview> aListOfReviews = new List<CustomerReview>();

            // Add our reviews to the list
            aListOfReviews.Add(aReview1);
            aListOfReviews.Add(aReview2);
            aListOfReviews.Add(aReview3);
            aListOfReviews.Add(aReview4);
            aListOfReviews.Add(aReview5);
            
            // Loop through the list and print the class data
            foreach (var review in aListOfReviews)
            {
                Console.WriteLine(review.ToString() + "\n\n");
            }

            // Hang until the user views the output
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
