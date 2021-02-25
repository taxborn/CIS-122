// Created by: Braxton Fair
// Created on: 02/23/2021

namespace InheritenceClass
{
    public class HummingBird : Bird
    {
        public HummingBird() : this("Humming Bird") { }
        public HummingBird(string name) : base(name, false, true, true, true, true, true, true) { }
    }
}
