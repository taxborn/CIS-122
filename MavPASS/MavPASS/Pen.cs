// Created by Braxton Fair
// Created on: 01/21/2021

using System;
using System.Collections.Generic;

namespace MavPASS
{
    public class Pen
    {
        // This are the variables that describe the pen
        private string brand = "Bic";
        private string color = "n/a";
        private string type = "n/a";
        private int length = 13;

        // These are the getters and setters for the pen
        // CHALLENGE: Have a read only and write only property

        // This getter/setter only has a get because it is READ-ONLY
        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

       // This getter/setter only has a set because it is WRITE-ONLY
        public int Length
        {
            set
            {
                this.length = value;
            }
        }

        public Pen(string color, string type, int length)
        {
            this.Color = color;
            this.Type = type;
            this.Length = length;
        }

        // This is the ToString method
        public override string ToString()
        {
            string classString =
                "The pen's brand is: " + this.Brand + "\n" +
                "The pen's color is: " + this.Color + "\n" +
                "The pen's type is: " + this.Type + "\n" +
                "The pen's length is: " + this.length;

            return classString;
        }
    }
}
