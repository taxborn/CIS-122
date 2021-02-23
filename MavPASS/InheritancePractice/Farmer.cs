// Created by: Braxton Fair
// Created on: 02/22/2021

namespace InheritancePractice
{
    public class Farmer : Job
    {
        // our private variables
        private string location = "n/a";
        private string crop = "n/a";

        // our gets and sets
        public string Location
        {
            get => this.location;
            set => this.location = value;
        }

        public string Crop
        {
            get => this.crop;
            set => this.crop = value;
        }

        // our constructor
        public Farmer(string jobId, bool fired, string location, string crop)
        {
            this.JobID = jobId;
            this.IsFired = fired;
            this.Location = location;
            this.Crop = crop;
        }

        // our other methods
        public override string ToString()
        {
            string classString = 
                "ID: " + this.JobID + "\n" +
                "Fired: " + this.IsFired + "\n" +
                "--------\n" + 
                "\tLocation: " + this.Location + "\n" +
                "\tCrop: " + this.Crop;

            return classString;
        }
    }
}
