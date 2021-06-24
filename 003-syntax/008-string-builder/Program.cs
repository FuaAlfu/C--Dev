using System;
using System.Text;

/// <summary>
/// 2021.6.24
/// </summary>

/*
TODO
*/

namespace _008_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare capacity by 60  
            StringBuilder myString = new StringBuilder("you are awesome ", 60);

            //append a new line
            myString.Append("dude.. ");

            //append another new line 
            myString.AppendLine("hell yeah..");

            myString.Append("duuuudes ...");
            Console.WriteLine(myString);
        }
    }
}
