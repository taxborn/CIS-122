// Created by: Braxton Fair
// Created on: 01/28/2021
using System;
using System.Collections.Generic;

namespace Quiz2
{
    public class SweatShirt
    {
        // Our private class variables
        private int mfgNumber = 951751654;
        private int companyNumber = 741852;
        private string color = "n/a";
        private string size = "S";
        private double price = 7539518.52;

        // Our gets and sets (properties)
        public int MFGNumber
        {
            get
            {
                return this.mfgNumber;
            }

            set
            {
                this.mfgNumber = value;
            }
        }

        public int CompanyNumber
        {
            get
            {
                return this.companyNumber;
            }

            set
            {
                this.companyNumber = value;
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

        public string Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        // Our constructor
        public SweatShirt(int mfgNumber, int companyNumber, string color, string size, double price)
        {
            this.MFGNumber = mfgNumber;
            this.CompanyNumber = companyNumber;
            this.Color = color;
            this.Size = size;
            this.Price = price;
        }

        // Our other methods (like ToString)
        public override string ToString()
        {
            string classString =
                "Manufactoring Number: " + this.MFGNumber + "\n" +
                "Company Number: " + this.CompanyNumber + "\n" +
                "Color: " + this.Color + "\n" +
                "Size: " + this.Size + "\n" +
                "Price: $" + this.Price;

            return classString;
        }

    }
}
