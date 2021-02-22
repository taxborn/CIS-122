// Created by: CIS-122 MavPass
// Created on: 02/18/2021

using System;

namespace Nested
{
    public class Tree
    {
        // our private variables
        private int maxNumber = -1;
        private string character = "n/a";

        // our gets and sets
        public int MaxNumber
        {
            get
            {
                return this.maxNumber;
            }

            set
            {
                this.maxNumber = value;
            }
        } 

        public string Character
        {
            get
            {
                return this.character;
            }

            set
            {
                this.character = value;
            }
        } 

        // our constructors
        public Tree(int max, string character)
        {
            this.MaxNumber = max;
            this.Character = character; 
        }

        public Tree() : this(4, "*") { }
        public Tree(int max) : this(max, "*") { }

        // our methods
        public override string ToString()
        {
            string message = "";

            // nested for loop time - this can be either here, or we can extract it to its own function like CreateTree()
            //
            // start at 1, go to the max number, run loop from 1 to ax number, every time it runs, add another character
            // to the output string
            for (var i = 1; i <= this.MaxNumber; i++) 
            {
                // create a variable to be less than the max number, and increment it each time
                for (var x = 1; x <= i; x++)
                {
                    message += this.Character;
                }

                message += "\n";
            }

            return message;
        } 
    }
}
