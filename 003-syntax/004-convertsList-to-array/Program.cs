using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 2021.6.20
/// </summary>

/*
TODO
*/
namespace _004_convertsList_to_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a dynamic range of array --> list.
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(100);
            list.Add(1000);
            list.Add(10000);
            list.Add(100000);

            // Step 2: convert to string array.
            int[] array = list.ToArray();
            Testing(array);
        }

        static void Testing(int[] array)
        {
            Console.WriteLine("Array received: " + array.Length);
        }
    }
}

