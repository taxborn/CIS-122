// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class Ostrich : Bird
    {
        public Ostrich() : this("Ostrich") { }
        public Ostrich(string name) : base(name, true, true, false, true, false, false, false) { }
    }
}
