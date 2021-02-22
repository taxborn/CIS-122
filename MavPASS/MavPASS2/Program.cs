// Created by: Braxton Fair
// Created by: 01/25/2021

// Generic imports that we need
using System;
using System.Collections.Generic;

namespace MavPASS2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Key aKey1 = new Key("a");
            Key aKey2 = new Key("b");
            Key aKey3 = new Key("c");

            List<Key> myKeys = new List<Key>();

            myKeys.Add(aKey1);
            myKeys.Add(aKey2);
            myKeys.Add(aKey3);

            Keyboard myKeyboard = new Keyboard("Logitech", "QWERTY", myKeys);

            Console.WriteLine(myKeyboard.ToString());

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
