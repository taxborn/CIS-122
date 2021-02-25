// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class Duck : Bird
    {
        public Duck() : this("Duck") { }
        public Duck(string name) : base(name, false, true, true, true, true, false, true) { }
    }
}
