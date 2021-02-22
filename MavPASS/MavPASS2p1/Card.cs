// Created by: Braxton Fair
// Created on: 01/25/2021

using System;
using System.Collections.Generic;

namespace MavPASS2p1
{
    public class Card
    {
        // Our private variables
        private string suit = "n/a";
        private string faceValue = "n/a";

        // Our getters and setters
        public string Suit
        {
            get
            {
                return this.suit;
            }

            set
            {
                this.suit = value;
            }
        }

        public string FaceValue
        {
            get
            {
                return this.faceValue;
            }

            set
            {
                this.faceValue = value;
            }
        }

        // Our constructor
        public Card(string suit, string faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
        }

        // Our ToString
        public override string ToString()
        {
            string classString =
                "Suit: " + this.Suit + "\n" +
                "Value: " + this.FaceValue;

            return classString;
        }
    }
}
