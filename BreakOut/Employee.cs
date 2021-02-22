// Created by: Braxton Fair
// Created on: 02/11/2021

using System;

namespace BreakOut
{
    public class Employee
    {
        // private variables
        private int id = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private int postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private int extension = "n/a";
        private string photo = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        // our gets and sets
        public int Id {
            get => this.id;
            set => this.id = value;
        }
        
        public string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }

        public string FirstName
        {
            get => this.firstName;
            set => this.firstName = value;
        }

        public string Title
        {
            get => this.title;
            set => this.title = value;
        }
        
        public string TitleOfCourtesy
        {
            get => this.titleOfCourtesy;
            set => this.titleOfCourtesy = value;
        }

        public string BirthDate
        {
            get => this.birthDate;
            set => this.birthDate = value;
        }

        public string HireDate
        {
            get => this.hireDate;
            set => this.hireDate = value;
        }

        public string Address
        {
            get => this.address;
            set => this.address = value;
        }

        public string City
        {
            get => this.city;
            set => this.city = value;
        }

        public string Region
        {
            get => this.region;
            set => this.region = value;
        }

        public int PostalCode
        {
            get => this.postalCode;
            set => this.postalCode = value;
        }

        public string Country 
        {
            get => this.country;
            set => this.country = value;
        }

        public string HomePhone
        {
            get => this.homePhone;
            set => this.homePhone = value;
        }

        public int Extension
        {
            get => this.extension;
            set => this.extension = value;
        }

        public string Photo
        {
            get => this.photo;
            set => this.photo = value;
        }

        public string Notes
        {
            get => this.notes;
            set => this.notes = value;
        }
        
        public int ReportsTo
        {
            get => this.reportsTo;
            set => this.reportsTo = value;
        }

        // our constructor
        public Employee(int id, string lastName, string firstName, string title, string titleOfCourtesy, string birthDate, string hireDate, string address, string city, string region, int postalCode, string country, string homePhone, int extension, string photo, string notes, int reportsTo)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Title = title;
            this.TitleOfCourtesy = titleOfCourtesy;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
            this.HomePhone = homePhone;
            this.Extension = extension;
            this.Photo = photo;
            this.Notes = notes;
            this.ReportsTo = reportsTo;
        }
    }
}
