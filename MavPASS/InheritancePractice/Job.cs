// Created by: Braxton Fair
// Created on: 02/22/2021

namespace InheritancePractice
{
    public abstract class Job
    {
        // our private variables
        private string jobID = "n/a"; 
        private bool isFired = false;

        // our gets and sets
        public string JobID
        {
            get => this.jobID;
            set => this.jobID = value;
        }

        public bool IsFired
        {
            get => this.isFired;
            set => this.isFired = value;
        }

        // our constructor
        // Constructors are not inherited, so these are mostly useless
        
        public Job(): this("123", false) {}

        public Job(string job, bool fired)
        {
            this.JobID = job;
            this.IsFired = fired;
        }
        
        // our methods
        public override string ToString()
        {
            string classString = 
                "ID: " + this.JobID + "\n" +
                "Fired?: " + this.IsFired;

            return classString;
        }

    }
}
