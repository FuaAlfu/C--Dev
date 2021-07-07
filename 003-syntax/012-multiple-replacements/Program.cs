using System;

namespace _012_multiple_replacements
{
    class Program
    {
        const string MY_VALUE = "abcabc";
        static void Main(string[] args)
        {

            Console.WriteLine("MY_VALUE Before: " + MY_VALUE);

            /*
             Store the result of Replace() in a variable.
             and then all instances of the substring are replaced.
             */
            string modified = MY_VALUE.Replace("bc", "?");
            Console.WriteLine("MY_VALUE After:  " + modified);
        }
    }
}
