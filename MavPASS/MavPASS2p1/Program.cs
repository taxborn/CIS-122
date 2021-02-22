// Created by: Braxton Fair
// Created on: 01/25/2021
using System;
using System.Collections.Generic;

namespace MavPASS2p1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create some cards
            Card ace = new Card("spades", "A");
            Card two = new Card("spades", "2");
            Card three = new Card("spades", "3");
            Card four = new Card("spades", "4");
            
            // Create a list out of our cards
            List<Card> cards = new List<Card>();

            cards.Add(ace);
            cards.Add(two);
            cards.Add(three);
            cards.Add(four);

            // Our first deck
            DeckOfCards deck = new DeckOfCards("Bicycle", cards);

            Console.WriteLine(deck.ToString());

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
