// Created by: Braxton Fair
// Created on: 02/11/2021

using System;

namespace FizzBuzz.Models
{
    public class Fizzy
    {
        // our private variables
        private int counter = -1;

        // our gets and sets
        public int Counter
        {
            get => this.counter;
            set => this.counter = value;
        }        

        // constructors
        public Fizzy() : this(100) { }

        public Fizzy(int counter)
        {
            this.Counter = counter;
        }

        // our methods
        public string Check()
        {
            if (this.Counter % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (this.Counter % 3 == 0)
            {
                return "Fizz";
            }
            else if (this.Counter % 5 == 0)
            {
                return "Buzz";
            }

            return $"{this.Counter}";
        }

        public override string ToString()
        {
            return Check();
        }
    }
}
