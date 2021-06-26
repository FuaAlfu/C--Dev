using System;
using System.Text;

/// <summary>
/// 2021.6.26
/// </summary>

/*
TODO
*/
namespace _009_StringBuilder.Replace__
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare capacity by 20
        StringBuilder myString = new StringBuilder("### is a Russian signer ", 20);
          
        //replace "###" with "yuta"
        myString.Replace("###", "yuta");
  
        Console.WriteLine(myString);
        }
    }
}
