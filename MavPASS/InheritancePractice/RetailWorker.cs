// Created by: Braxton Fair
// Created on: 02/22/2021

namespace InheritancePractice
{
    public class RetailWorker : Job
    {
        // our private variables
        private string storeLocation = "n/a";
        private string brandName = "n/a";

        // our gets and sets
        public string StoreLocation
        {
            get => this.storeLocation;
            set => this.storeLocation = value;
        }

        public string BrandName
        {
            get => this.brandName;
            set => this.brandName = value;
        }

        // our constructor
        public RetailWorker(string jobid, bool fired, string location, string brand)
        {
            this.JobID = jobid;
            this.IsFired = fired;
            this.StoreLocation = location;
            this.BrandName = brand;
        }

        // our other methods
        public override string ToString()
        {
            string classString =
                "Location: " + this.StoreLocation + "\n" +
                "Brand: " + this.BrandName;

            return classString;
        }
    }
}
