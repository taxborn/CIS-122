// Created by Braxton Fair
// On 01/14/2021

// Libraries we are using
using System;
using System.Collections.Generic;

// The namespace is the project we are working on
namespace HelloWorld
{
    // A class is a way to organize units of data, and will usually be public
    public class Student
    {
        // We first use our private class variables
        // These variables are ENCAPSULATED
        // This data should be atomic
        // Don't just use "name", it should be broken down to first, middle, and last name
        // Be aware of cultural differences
        // E.g. Not all cultures use last names, or middle names, etc..
        // private variables are camelCased
        // Typically, if we want to use integers, like for techId, if we are not preforming 
        // Mathematical operations on it, 
        private string studentId = "000000";
        private string firstName = "John";
        private string middleName = "Roberts";
        private string lastName = "Doe";
        private int techId = -1;

        // We use getters and setters to make private variables accessable
        // Getters and setters are PascalCased
        // If we don't use setters, that means the data is immutable but visible
        // If we don't use getters, that means the data is mutable but invisible
        public string StudentId
        {
            get
            {
                return this.studentId;
            }

            set
            {
                // We can use if statments to validate the input
                // if (value.Length == 0)
                //      this.studentId = "xxx" <-- default value 
                // else
                //      this.studentId = value;
                this.studentId = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                //return this.firstName + " " + this.middleName + " " + this.lastName;
                /*
                 * Use the uppercase version to use the getters of the variables. That way, if we are rendering the content differently,
                 * it will be reflected here. It is generally a good rule of thumb to do it this way, rather than directly accessing
                 * the variables.
                 * 
                 * WRONG:
                 * return this.firstName + " " + this.middleName + " " + this.lastName;
                 */
                return this.FirstName + " " + this.MiddleName + " " + this.LastName; 
            }
        }

        public int TechId
        {
            get
            {
                return this.techId;
            }

            set
            {
                this.techId = value;
            }
        }

        public Student(string firstName, string middleName, string lastName, string studentId, int techId)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.StudentId = studentId;
            this.TechId = techId;
        }

        // Methods start after variable instanciation and getters and setters
        public override string ToString()
        {
            // Again, whenever possible, use the getter methods
            // Note: Do NOT put display codes (\n) in your Domain Class, because
            // different platforms handle display codes differently
            // This is a domain class. 

            string classString = "Full name: " + this.FullName + "\n" +
                "First Name: " + this.FirstName + "\n" +
                "Middle Name: " + this.MiddleName + "\n" +
                "Last Name: " + this.LastName + "\n" +
                "Student Id: " + this.StudentId + "\n" +
                "Tech Id: " + this.TechId;

            return classString;
        }
    }
}
