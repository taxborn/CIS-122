// Created by: Braxton Fair
// Created on: 01/28/2021
using System;
using System.Collections.Generic;

namespace MavPASS3
{
    public class Card
    {
        // Our private variables
        private string suit = "n/a";
        private string faceValue = "na";

        // Our getters and setters
        public string Suit
        {
            get => this.suit;
            set => this.suit = value;
        }

        public string FaceValue
        {
            get => this.faceValue;
            set => this.faceValue = value;
        }

        // Our constructor
        public Card(string suit, string faceValue)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
        }

        // Our methods
        public override string ToString()
        {
           string classString = 
              "This card is the " + this.FaceValue + " of " + this.Suit; 

           return classString;
        }
    }
}
