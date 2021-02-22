﻿// Created by: Braxton Fair
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
            get => this.brand;
            set => this.brand = value;
        }

        public List<Card> Cards
        {
            get => this.cards;
            set => this.cards = value;
        }

        // Our constructor
        public DeckOfCards(string brand, List<Card> cards)
        {
            this.Brand = brand;
            this.Cards = cards;
        }

        public string GetCards()
        {
            string message = "";

            foreach (var card in this.Cards)
            {
                message += "\t" + card.ToString() + "\n";
            }

            return message;
        }

        // Our methods
        public override string ToString()
        {
            string classString = 
                "Brand: " + this.Brand + "\n" +
                "Cards: \n" + this.GetCards();

            return classString;
        }
    }
}
