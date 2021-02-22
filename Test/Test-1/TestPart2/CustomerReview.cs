// Created by: Braxton Fair
// Created on: 02/16/2021

namespace TestPart2
{
    public class CustomerReview
    {
        // our private varibles
        private int numberOfStars = -1;
        private int reviewerId = 15;
        private string reviewText = "n/a";
        private string reviewDate = "n/a";
        private string verifiedPurchase = "n/a";

        // our gets and sets
        public int NumberOfStars
        {
            get
            {
                return this.numberOfStars;
            }

            set
            {
                this.numberOfStars = value;
            }
        }

        public int ReviewerId
        {
            get
            {
                return this.reviewerId;
            }
        }

        public string ReviewText
        {
            get
            {
                return this.reviewText;
            }

            set
            {
                this.reviewText = value;
            }
        }

        public string ReviewDate
        {
            get
            {
                return this.reviewDate;
            }

            set
            {
                this.reviewDate = value;
            }
        }

        public string VerifiedPurchase
        {
            get
            {
                return this.verifiedPurchase;
            }

            set
            {
                this.verifiedPurchase = value;
            }
        }

        // our constructors
        public CustomerReview(): this(4, "Good", "01/01/1969", "John Doe") { }

        public CustomerReview(int stars, string review, string date, string verified)
        {
            this.NumberOfStars = stars;
            this.ReviewText = review;
            this.ReviewDate = date;
            this.VerifiedPurchase = verified;
        }

        public CustomerReview(int stars): this(stars, "Good", "01/01/1969", "John Doe") {}

        public CustomerReview(int stars, string review, string date): this(stars, review, date, "John Doe") { }

        // Our other methods:
        public override string ToString()
        {
            string classString =
                "Stars: " + this.NumberOfStars + " \n" +
                "Review: " + this.ReviewText + " \n" +
                "Reviewer ID: " + this.ReviewerId + " \n" +
                "Date: " + this.ReviewDate + " \n" +
                "Verified Purchase: " + this.VerifiedPurchase;

            return classString;
        }
    }
}
