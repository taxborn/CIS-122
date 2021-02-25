// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class Hawk : Bird
    {
        public Hawk() : this("Hawk") { }
        public Hawk(string name) : base(name, true, false, true, true, true, false, false) { }
    }
}
