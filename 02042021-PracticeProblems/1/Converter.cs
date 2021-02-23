// Created by: Braxton Fair
// Created on: 02/05/2021

namespace _1
{
    public class Converter
    {
        // our gets and sets
        public int Days { get; set; }

        // our constructors
        public Converter() : this(10) { }
        public Converter(int days) => Days = days;

        // our other methods
        public int ToHours() => this.Days * 24;

        public int ToMinutes() => this.ToHours() * 60;

        public int ToSeconds() => this.ToMinutes() * 60;

        public override string ToString() => $"{this.Days} days equals\n{this.ToHours()} hours\n{this.ToMinutes()} minutes\n{this.ToSeconds()} seconds";
    }
}
