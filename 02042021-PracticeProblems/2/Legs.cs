// Created by: Braxton Fair
// Created on: 02/23/2021

using System;

namespace _2
{
    public class Legs
    {
        // our gets and sets
        public int Sheep    { get; set; }
        public int Cows     { get; set; }
        public int Chickens { get; set; }
        public int Goats    { get; set; }
        public int Cats     { get; set; }
        public int Dogs     { get; set; }
        public int Farmers  { get; set; }

        // our constructor
        public Legs(int sheep, int cows, int chickens, int goats, int cats, int dogs, int farmers)
        {
            this.Sheep    = sheep;
            this.Cows     = cows;
            this.Chickens = chickens;
            this.Goats    = goats;
            this.Cats     = cats;
            this.Dogs     = dogs;
            this.Farmers  = farmers;
        }

        public int NumberOfLegs()
        {
            return (this.Sheep * 4) + (this.Cows * 4) + (this.Chickens * 2) + (this.Goats * 4) +
                (this.Cats * 4) + (this.Dogs * 4) + (this.Farmers * 2);
        }

        // our methods
        public override string ToString()
        {
            string classString = 
                "There are " + this.NumberOfLegs() + " legs on the farm:\n" +
                this.Sheep + " sheep = " + this.Sheep * 4 + " legs\n" +
                this.Cows + " cows = " + this.Cows * 4 + " legs\n" +
                this.Chickens + " chickens = " + this.Chickens * 2 + " legs\n" +
                this.Goats + " goats = " + this.Goats * 4 + " legs\n" +
                this.Cats + " cats = " + this.Cats * 4 + " legs\n" +
                this.Dogs + " dogs = " + this.Dogs * 4 + " legs\n" +
                this.Farmers + " farmers = " + this.Farmers * 2 + " legs";

            return classString;
        }
    }
}
