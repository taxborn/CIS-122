// Created by: Braxton Fair
// Created on: 02/23/2021

using System;

namespace _7
{
    public class Summator
    {
        // gets and sets
        public int[] ourArray { get; set; }

        // constructor
        public Summator(int[] array) => ourArray = array;

        // Our methods
        public int CalculateMax(int amount)
        {
            int counter = 0;

            // Sort and reverse the array, that way we can get the first (amount) values easily
            // We could do without a reverse if we want to improve performance, and do something like
            // for (int idx = this.ourArray.Length; idx > this.ourArray.Length - amount; idx--) <---- UNCHECKED
            // but that doesn't look pretty.
            Array.Sort(this.ourArray);
            Array.Reverse(this.ourArray);

            for (int idx = 0; idx < amount; idx++)
            {
                counter += this.ourArray[idx];
            }

            return counter;
        }
    }
}
