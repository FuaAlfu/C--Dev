using System;

namespace _001_system
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 7.5f;
            Console.WriteLine(num);

            //using Math library
            Console.WriteLine(Math.Floor(num));
            Console.WriteLine(Math.Ceiling(num));
            Console.WriteLine(Math.Round(num));
        }
        
    }
}
