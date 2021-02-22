// Created by: Braxton Fair
// Created on: 01/28/2021

using System;
using System.Collections.Generic;

namespace MavPASS3
{
    public class Key
    {
        // Create our private variables
        private string keyValue = "n/a";
        private string keySwitch = "n/a";

        // Our gets and sets
        public string KeyValue
        {
            get => this.keyValue;
            set => this.keyValue = value;
        }

        public string KeySwitch
        {
            get => this.keySwitch;
            set => this.keySwitch = value;
        }

        // Our constructor
        public Key(string keyValue, string keySwitch)
        {
            this.KeyValue = keyValue;
            this.KeySwitch = keySwitch;
        }

        // Our other methods
        public override string ToString()
        {
            string classString = 
                "Key: " + this.KeyValue + "\n" +
                "Switch: " + this.KeySwitch;

            return classString;
        }
    }
}
