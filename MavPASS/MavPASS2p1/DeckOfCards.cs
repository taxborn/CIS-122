// Created by: Braxton Fair
// Created on: 01/25/2021
using System;
using System.Collections.Generic;

namespace MavPASS2p1
{
    public class DeckOfCards
    {
        // Our private variables
        private string brand = "n/a";
        private List<Card> cards = new List<Card>();

        // Our getters and setters
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.brand = value;
            }
        }

        public List<Card> Cards
        {
            get => return this.cards;
            set
            {
                this.cards = value;
            }
        }

        // Our constructor
        public DeckOfCards(string brand = "Test", List<Card> cards)
        {
            this.Brand = brand;
            this.Cards = cards;
        }

        public string GetCards()
        {
            string message = "A: ";

            foreach (var card in this.Cards)
            {
                message += card.ToString();
                message += "\n"; 
            }

            return message;
        }

        // Our methods
        public override string ToString()
        {
            string classString = 
                "Brand: " + this.Brand + "\n" +
                "Cards: " + this.GetCards();

            return classString;
        }
    }
}
