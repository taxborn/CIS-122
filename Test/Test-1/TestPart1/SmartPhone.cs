// Created by: Braxton Fair
// Created  on: 02/16/2021

using System;
using System.Collections.Generic;

namespace TestPart1
{
    public class SmartPhone
    {
        // our private variables
        private bool rearCamera = false;
        private bool frontCamera = false;
        private string processor = "n/a";
        private float memoryInGB = -1.0f;
        private double batteryInMAH = 10000.00;

        // our gets and sets
        public bool RearCamera
        {
            get
            {
                return this.rearCamera;
            }

            set 
            {
                this.rearCamera = value;
            }
        }

        public bool FrontCamera
        {
            get
            {
                return this.frontCamera;
            }

            set
            {
                this.frontCamera = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                this.processor = value;
            }
        }

        public float MemoryInGB
        {
            get
            {
                return this.memoryInGB;
            }

            set
            {
                this.memoryInGB = value;
            }
        }

        public double BatteryInMAH
        {
            get
            {
                return this.batteryInMAH;
            }
        }

        // our constructors
        public SmartPhone(bool rearCamera, bool frontCamera, string processor, float memoryInGB)
        {
            this.RearCamera = rearCamera;
            this.FrontCamera = frontCamera;
            this.Processor = processor;
            this.MemoryInGB = memoryInGB;
        }

        // our other methods (like ToString)
        public override string ToString()
        {
            string classString = 
                "Rear Camera: " + this.RearCamera + " \n" + 
                "Front Camera: " + this.FrontCamera + " \n" + 
                "Processor: " + this.Processor + " \n" + 
                "Memory: " + this.MemoryInGB + "GB \n" + 
                "Battery: " + this.BatteryInMAH + "MAH";

            return classString;
        }
    }
}
