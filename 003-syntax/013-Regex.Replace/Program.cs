using System;
using System.Text.RegularExpressions;

/// <summary>
/// 2021.7.8
/// </summary>

namespace _013_Regex.Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "bird0 cat1 bird2 cat2 bird.";
            Console.WriteLine("Before: " + value);

            // Match all strings starting with "bird" and ending with a digit and non-word character.
            //Replace them with an empty string literal.
            string result = Regex.Replace(value, @"bird\d\W", "");
            Console.WriteLine("After:  " + result);
        }
    }
}
