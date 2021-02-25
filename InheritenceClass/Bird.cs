// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public abstract class Bird
    {   
        // private variables
        private string name = "n/a";
        private bool hasTalons = false;
        private bool hasWebbedFeet = false;
        private bool hasWings = false;
        private bool hasFeathers = false;
        private bool canFly = false;
        private bool canHover = false;
        private bool canSwim = false;

        // our gets and sets
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public bool HasTalons
        {
            get => this.hasTalons;
            set => this.hasTalons = value;
        }

        public bool HasWebbedFeet
        {
            get => this.hasWebbedFeet;
            set => this.hasWebbedFeet = value;
        }

        public bool HasWings
        {
            get => this.hasWings;
            set => this.hasWings = value;
        }

        public bool HasFeathers
        {
            get => this.hasFeathers;
            set => this.hasFeathers = value;
        }

        public bool CanFly
        {
            get => this.canFly;
            set => this.canFly = value;
        }

        public bool CanHover
        {
            get => this.canHover;
            set => this.canHover = value;
        }

        public bool CanSwim
        {
            get => this.canSwim;
            set => this.canSwim = value;
        }

        // our constructors
        public Bird(string name, bool talons, bool webbed, bool wings, bool feathers, bool fly, bool hover, bool swim)
        {
            this.Name = name;
            this.HasTalons = talons;
            this.HasWebbedFeet = webbed;
            this.HasWings = wings;
            this.HasFeathers = feathers;
            this.CanFly = fly;
            this.CanHover = hover;
            this.CanSwim = swim;
        }

        // our methods
        public override string ToString()
        {
            string classString = 
                "Name: " + this.Name + "\n" +
                "HasTalons: " + this.HasTalons + "\n" +
                "HasWebbedFeet: " + this.HasWebbedFeet + "\n" +
                "HasWings: " + this.HasWings + "\n" +
                "HasFeathers: " + this.HasFeathers + "\n" +
                "CanFly: " + this.CanFly + "\n" +
                "CanHover: " + this.CanHover + "\n" +
                "CanSwim: " + this.CanSwim + "\n";

            return classString;
        }
    }
}
