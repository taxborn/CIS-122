// Created by: Braxton Fair
// Created on: 02/23/2021

using System;

namespace InheritenceClass
{
    public class Eagle : Bird
    {
        // our constructors
        public Eagle() : this("Eagle") { }
        public Eagle(string name) : base(name, true, false, true, true, true, false, false) { }
    }
}
