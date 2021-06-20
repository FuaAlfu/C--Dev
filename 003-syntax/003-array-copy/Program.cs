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
namespace _003_array_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the source array.
            int[] myArray = new int[5];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            //here :: instantiate and allocate the target array.
            int[] t = new int[5];

            //copy the source to the target by copy function.
            Array.Copy(myArray, t, 5);

            //range over the target array.
            foreach (int value in t)
            {
                Console.WriteLine(value);
            }
        }
    }
}

