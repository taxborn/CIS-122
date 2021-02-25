// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class Seagull : Bird
    {
        public Seagull() : this("Seagull") { }
        public Seagull(string name) : base(name, false, true, true, true, true, false, true) { }
    }
}
