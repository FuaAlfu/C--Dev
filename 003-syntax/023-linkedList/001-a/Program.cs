using System;
using System.Collections.Generic;

namespace _001_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a single linkedlist by Using LinkedList class
            LinkedList<String> myList = new LinkedList<String>();

            // adding an element by using AddLast() method
            myList.AddLast("john");
            myList.AddLast("doe");
            myList.AddLast("is");
            myList.AddLast("awesome");

            // Ranging over a LinkedList Using foreach loop
            foreach (string name in myList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
