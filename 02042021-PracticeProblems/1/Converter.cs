// Created by: Braxton Fair
// Created on: 02/05/2021

namespace _1
{
    public class Converter
    {
        // Our constant variables
        public const int HoursInADay = 24, MinutesInAnHour = 60, SecondsInAMinute = 60;
        // our gets and sets
        public int Days { get; set; }

        // our constructors
        public Converter() : this(10) { }
        public Converter(int days) => Days = days;

        // our other methods
        public int ToHours() => this.Days * HoursInADay;

        public int ToMinutes() => this.ToHours() * MinutesInAnHour;

        public int ToSeconds() => this.ToMinutes() * SecondsInAMinute;

        public override string ToString() => $"{this.Days} days equals\n{this.ToHours()} hours\n{this.ToMinutes()} minutes\n{this.ToSeconds()} seconds";
    }
}
