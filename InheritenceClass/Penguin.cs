// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class Penguin : Bird
    {
        public Penguin() : this("Penguin") { }
        public Penguin(string name) : base(name, false, true, true, false, false, false, true) { }
    }
}
