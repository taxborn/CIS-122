// Created by: Braxton Fair
// Created on: 01/25/2021

// FIRST THING YOU DO ^^^

using System;
using System.Collections.Generic;

namespace MavPASS2
{
    public class Key
    {
        // 1st thing to do in the class:
        private string character = "n/a";
        // other private variables
        
        // 2nd: Getters and setters / properties
        public string Character
        {
            get => this.character;
            set => this.character = value;
        }

        // 3rd: Constructor
        public Key(string character)
        {
            this.Character = character;
        }

        // 4th: Methods / ToString
        public override string ToString()
        {
            string classString =
                "Key: " + this.Character;

            return classString;
        }
    } 
}
