// Created by: Braxton Fair
// Created on: 01/21/2021
using System;
using System.Collections.Generic;

namespace Quiz1
{
    public class WireCutter
    {
        // This is where the class's variables go
        private string itemNumber = "-1";
        private string itemName = "N/A";
        private string features = "N/A";
        private double unitPrice = -1.0;
        private double weight = -1.0;

        // Here is where our getters and setters for our variables go
        public string ItemNumber
        {
            set
            {
                this.itemNumber = value;
            }
        }

        public string ItemName
        {
            get
            {
                return this.itemName;
            }

            set
            {
                this.itemName = value;
            }
        }

        public string Features
        {
            get
            {
                return this.features;
            }

            set
            {
                this.features = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                this.unitPrice = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                this.weight = value;
            }
        }

        public string Description
        {
            get
            {
                return this.itemNumber + " " + this.ItemName + " " + this.UnitPrice;
            }
        }

        // This is our constructor to instanciate our class
        public WireCutter(string itemNumber, string itemName, string features, double unitPrice, double weight)
        {
            this.ItemNumber = itemNumber;
            this.ItemName = itemName;
            this.Features = features;
            this.UnitPrice = unitPrice;
            this.Weight = weight;
        }

        // This is where our other methods go, like ToString
        public override string ToString()
        {
            string classString = 
                "Item Name: " + this.ItemName + "\n" +
                "Features: " + this.Features + "\n" +
                "Unit Price: " + this.UnitPrice + "\n" +
                "Weight: " + this.Weight + "\n" +
                "Description: " + this.Description;

            return classString;
        }
    }
}
