// Created by: Braxton Fair
// Created on: 02/22/2021

namespace InheritancePractice
{
    public class Teacher : Job
    {
        // our private variables
        private string schoolName = "n/a";
        private int numberOfStudents = -1;

        // our gets and sets
        public string SchoolName
        {
            get => this.schoolName;
            set => this.schoolName = value;
        }

        public int NumberOfStudents
        {
            get => this.numberOfStudents;
            set => this.numberOfStudents = value;
        }

        // our constructor
        public Teacher(string jobId, bool fired, string name, int students)
        {
            this.JobID = jobId;
            this.IsFired = fired;
            this.SchoolName = name;
            this.NumberOfStudents = students;
        }

        // our other methods
        public override string ToString()
        {
            string classString =
                "ID: " + this.JobID + "\n" +
                "Fired: " + this.IsFired + "\n" +
                "--------\n" + 
                "\tName of school: " + this.SchoolName + "\n" +
                "\tNumber of students: " + this.NumberOfStudents;

            return classString; 
        }
    }
}
