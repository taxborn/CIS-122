// Created By: Braxton Fair
// Created on 01/19/2021
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Instructor
    {
        // Our private class variables
        private string firstName = "na";
        private string middleName = "na";
        private string lastName = "na";
        private string email = "na";
        private int techId = 000;

        public string FirstName
        {
            get => this.firstName;
            set => this.firstName = value;
        }

        public string MiddleName
        {
            get => this.middleName;
            set => this.middleName = value;
        }

        public string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }

        public string FullName
        {
            get => this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }

        public int TechId
        {
            get => this.techId;
            set => this.techId = value;
        }
        
        public string Email
        {
            get => this.email;
            set => this.email = value;
        }

        public Instructor(string firstName, string middleName, string lastName, string email, int techId)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Email = email;
            this.TechId = techId;
        }

        public override string ToString()
        {
            string instructorString =
                "Full Name: " + this.FullName + "\n" +
                "Tech Id: " + this.TechId + "\n" +
                "Email: " + this.Email;

            return instructorString;
        }
    }
}
