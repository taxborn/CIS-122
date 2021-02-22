// Created by: Braxton Fair
// Created on: 02/05/2021

namespace _1
{
    public class Converter
    {
        // our private variables
        private int days = -1;

        // our gets and sets
        public int Days
        {
            get => this.days;
            set => this.days = value;
        }

        // our constructors
        public Converter(int days)
        {
            this.days = days;
        }

        // our other methods
        public int ToHours() => this.days * 24;

        public int ToMinutes() => this.ToHours() * 60;

        public int ToSeconds() => this.ToMinutes() * 60;

        public override string ToString() => $"{this.days} days equals\n{this.ToHours()} hours\n{this.ToMinutes()} minutes\n{this.ToSeconds()} seconds";
    }
}
