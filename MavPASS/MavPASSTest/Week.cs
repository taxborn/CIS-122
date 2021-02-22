// Created by: Braxton Fair
// Created on: 02/16/2021

using System;
using System.Collections.Generic;

namespace MavPASSTest
{
    public class Week
    {
        // our private variables
        private List<Day> days;

        // our gets and sets
        public List<Day> Days
        {
            get => this.days;
            set => this.days = value;
        }

        // our constructor
        public Week(List<Day> days)
        {
            this.Days = days;
        }

        // Our methods
        public override string ToString()
        {
            string classString = "";

            foreach (var day in this.Days)
            {
                :w

            }
        }
    }
}
