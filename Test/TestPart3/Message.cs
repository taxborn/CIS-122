// Created by: Braxton Fair
// Created on: 02/16/2021

using System;
using System.Collections.Generic;

namespace TestPart3
{
    public class Message
    {
        // our private variables
        private string letter = "a";
        private int startingNumber = -1;
        private int endingNumber = -1;

        // our gets and sets
        public string Letter
        {
            get
            {
                return this.letter;
            }

            set
            {
                this.letter = value;
            }
        }

        public int StartingNumber
        {
            get
            {
                return this.startingNumber;
            }

            set
            {
                this.startingNumber = value;
            }
        }

        public int EndingNumber
        {
            get
            {
                return this.endingNumber;
            }

            set
            {
                this.endingNumber = value;
            }
        }

        // our constructors
        public Message(string letter, int start, int end)
        {
            this.Letter = letter;
            this.StartingNumber = start;
            this.EndingNumber = end;
        }

        // Our methods
        public string CreateMessage()
        {
            string output = "";

            // Loop starting at StartingNumber, ending at EndingNumber
            for (var idx = this.StartingNumber; idx <= this.EndingNumber; idx++)
            {
                for (var jdx = 1; jdx <= 10; jdx++)
                {
                    // Will format as "i + j = (i + j))
                    //
                    // The parenthasis are needed because otherwise C# thinks we are concatinating
                    // The two numbers, rather than adding them
                    output += idx + " + " + jdx + " = " + (idx + jdx) + "\n"; 
                }

                // Add a new line for clarity
                output += "\n";
            }

            return output;
        }
    }
}
