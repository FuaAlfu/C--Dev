using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 2021.6.21
/// </summary>

/*
TODO
*/

namespace _005_ListConstructorAndToList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string array.
            string[] array = new string[]
            {
            "apple",
            "orange",
            "banana",
            };

            //list constructor.
            List<string> list1 = new List<string>(array);
            Testing(list1);

            //here ..ToList method.
            List<string> list2 = array.ToList();
            Testing(list2);
        }

        static void Testing(List<string> list)
        {
            Console.WriteLine("List count: " + list.Count);
        }
    }
}
