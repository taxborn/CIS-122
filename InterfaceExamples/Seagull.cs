// Created by: Braxton Fair
// Created on: 02/25/2021

namespace InterfaceExamples
{
    public class Seagull : Flyable, Swimmable
    {
        public string Fly()
        {
            return "Flap flap";
        } 

        public string Swim()
        {
            return "Slish Sploosh";
        }
    }
}
