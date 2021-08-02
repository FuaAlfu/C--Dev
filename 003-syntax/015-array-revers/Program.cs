using System;

namespace _015_array_revers
{
    /*
    notes..
    */

    class Program
    {
        static void Main(string[] args)
        {
            
        int[] array = { 1, 2, 3 };

        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        
        //Reverse method
        Array.Reverse(array);
        
        //range over array
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        
        //Reverse again :: return
        Array.Reverse(array);
        
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        }
    }
}
