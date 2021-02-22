// Created by: Braxton Fair
// Created on: 01/28/2021

using System;
using System.Collections.Generic;

namespace MavPASS3
{
    public class Keyboard
    {
        // Create our private variables
        private string color = "n/a";
        private List<Key> keys = new List<Key>();

        // Our gets and sets (properties)
        public string Color
        {
            get => this.color;
            set => this.color = value;
        }

        public List<Key> Keys
        {
            get => this.keys;
            set => this.keys = value;
        }

        // Our constructor
        public Keyboard(string color, List<Key> keys)
        {
            this.Color = color;
            this.Keys = keys;
        }

        // Our other methods
        public string GetKeys()
        {
            string message = "";

            foreach (var key in this.Keys)
            {
                message += key.ToString();
            }

            return message;
        }

        public override string ToString()
        {
            string classString = 
                "Keyboard color: " + this.Color + "\n" +
                "Keys: " + this.GetKeys();
            
            return classString;
        }
    }
}
