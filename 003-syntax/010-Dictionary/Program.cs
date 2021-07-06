using System;
using System.Collection.Generics;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 2021.7.1
/// </summary>

/*
TODO
*/

namespace _010_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Adding key/value pairs 
           in the Dictionary
           Using Add() method
            */
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Welcome");
            myDictionary.Add(2, "to");
            myDictionary.Add(3, "myDictionary");

            //e means elements
            foreach (KeyValuePair<int, string> e in myDictionary)
            {
                Console.WriteLine("{0} and {1}" + e.Key + e.Value);
            }
            Console.WriteLine();
        }
    }
}
