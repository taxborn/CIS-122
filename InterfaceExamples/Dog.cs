// Created by: Braxton Fair
// Created on: 02/25/2021

namespace InterfaceExamples
{
    public class Dog
    {
        private Flyable flyingClass;

        public Dog(Flyable aFlyingClass)
        {
            this.flyingClass = aFlyingClass;
        }

        public string Fly()
        {
            this.flyingClass.Fly(); 
        }
    }
}
