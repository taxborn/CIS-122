// Created by: Braxton Fair
// Created on: 02/15/2021

using System;
using System.Collections.Generic;

namespace MavPASSTest
{
    public class Month
    {
        // Our private variables
        private int weeks;

        // Our gets and sets
        public int Weeks
        {
            get => this.weeks;
            set => this.weeks = value;
        }

        // Our constructors
        public int Month(int weeks)
        {
            this.Weeks = weeks;
        }

        // Our ToString
        public override string ToString()
        {
            string classString = "";

            for (var i = 1; i <= this.Weeks; i++)
            {
                classString += $"Week #{i}: "; // Week #1, Week #2 ...

                for (var j = 1; j <= 7; j++)
                {
                    classString += $"Day #{j} "; // Day #1, Day #2 ...
                }

                classString += "\n";
            }

            return classString;
        }
    }
}
