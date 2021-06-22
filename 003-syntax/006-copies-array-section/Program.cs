using System;

namespace _006_copies_array_section
{
    class Program
    {
        static void Main(string[] args)
        {
            // an integer array.
        int[] myArray = new int[]{10,20,30,40,50,60,70,80,90,100};

        // Instantiate the target.
        int[] t = new int[3];

        // Copy first 3 elements in myArray to target.
        Array.Copy(myArray, 0, t, 0, 3);

        // ranging over the target.
        foreach (int value in t)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine("---");

        //print the length of myArray
        Console.WriteLine("the length of myArray: " + myArray.Length);
        }
    }
}
