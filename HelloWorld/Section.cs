// Created by Braxton Fair
// Created on 01/19/2021
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Section
    {
        private string courseNumber = "000";
        private string sectionNumber = "00";
        private string time = "00:00";
        private string roomNumber = "000";
//        private string day = "N";
        private List<Student> roster = new List<Student>();
        private Instructor aInstructor = null;

        // Our gets and sets for our class
        public string CourseNumber
        {
            get => this.courseNumber;
            set => this.courseNumber = value;
        }

        public string SectionNumber
        {
            get => this.sectionNumber;
            set => this.sectionNumber = value;
        }

        public string Time
        {
            get => this.time;
            set => this.time = value;
        }

        public string RoomNumber
        {
            get => this.roomNumber;
            set => this.roomNumber = value;
        }

        public List<Student> Roster
        {
            get => this.roster;
        }

        public Instructor AInstructor
        {
            get => this.aInstructor;
            set => this.aInstructor = value;
        }

        // the rest of the gets and sets go here

        // Methods for our class
        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        public string GetClassList()
        {
            string classList = "";

            foreach (var student in this.Roster) {
                classList = classList + student.ToString() + "\n";
            }

            return classList;
        }

        public Section(string courseNumber, string sectionNumber, string time, string roomNumber, Instructor instructor)
        {
            this.CourseNumber = courseNumber;
            this.SectionNumber = sectionNumber;
            this.Time = time;
            this.RoomNumber = roomNumber;
            this.AInstructor = instructor;
        }

        public override string ToString()
        {
            string rosterMessage = 
                "Instructor: \n\n" + this.AInstructor.ToString() + "\n\n" +
                "Section Number: " + this.SectionNumber + "\n" +
                "Time: " + this.Time + "\n" +
                "Room Number: " + this.RoomNumber + "\n" +
                "Course Number: " + this.CourseNumber;

            return rosterMessage;
        }
    }
}
