// Created by: Braxton Fair
// Created on: 01/28/2021

using System;
using System.Collections.Generic;

namespace MavPASS3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create some keys for our keyboard
            Key aKey1 = new Key("A", "MX Black");
            Key aKey2 = new Key("B", "MX Red");
            Key aKey3 = new Key("C", "MX Blue");
            Key aKey4 = new Key("D", "MX Black");

            // Create a list for the keys and add them to the list
            List<Key> aListOfKeys = new List<Key>();

            aListOfKeys.Add(aKey1);
            aListOfKeys.Add(aKey2);
            aListOfKeys.Add(aKey3);
            aListOfKeys.Add(aKey4);

            // Create a keyboard
            Keyboard myKeyboard = new Keyboard("Black", aListOfKeys);

            Console.WriteLine(myKeyboard.ToString());

            // Create some cards for our deck of cards
            Card aCard1 = new Card("A", "Spades");
            Card aCard2 = new Card("10", "Diamonds");
            Card aCard3 = new Card("4", "Clubs");
            Card aCard4 = new Card("8", "Hearts");

            // Create a deck of cards for our cards and add them to the list
            List<Card> aListOfCards = new List<Card>();

            aListOfCards.Add(aCard1);
            aListOfCards.Add(aCard2);
            aListOfCards.Add(aCard3);
            aListOfCards.Add(aCard4);

            DeckOfCards myDeck = new DeckOfCards("Bicycle", aListOfCards);

            Console.WriteLine(myDeck.ToString());

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
