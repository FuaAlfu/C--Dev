using System;

namespace _011_Replace_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and print a string.
            string input = "abc";
            Console.WriteLine(input);


            //Assign to the Replace method's result.
            string output = input.Replace("abc", "hello ");
            Console.WriteLine(output);
        }
    }
}
