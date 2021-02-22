// Created by: Braxton Fair
// Created on: 01/25/2021
using System;
using System.Collections.Generic;

namespace MavPASS2
{
   public class Keyboard
   {
        // Our private variables
        private string brand = "n/a";
        private string layout = "n/a";
        private List<Key> keys = new List<Key>();

        // getters and setters
        public string Brand
        {
            get => this.brand;
            set => this.brand = value;
        }

        public string Layout
        {
            get => this.layout;
            set => this.layout = value;
        }
    
        public List<Key> Keys
        {
            get => this.keys;
            set => this.keys = value;
        }

        // The constructor for the class
        public Keyboard(string brand, string layout, List<Key> keys)
        {
            this.Brand = brand;
            this.Layout = layout;
            this.Keys = keys;
        }


        // The other methods
        public string ListKeys()
        {
            string output = "";

            foreach (var key in this.Keys)
            {
                output += "\t" + key.ToString() + "\n";
            }

            return output;
        }

        public override string ToString()
        {
            string classString = 
                "Brand: " + this.Brand + "\n" +
                "Layout: " + this.Layout + "\n" +
                "Keys: \n" + ListKeys();

            return classString;
        }
   } 
}
