using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 2021.6.11
/// </summary>

/*
TODO
*/
namespace _001_ref_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100;

            Console.WriteLine("Hello everyone!");
            /*
           ref keyword
           force a value type pass by reference
           to reflect the change inside the function
            */

            Console.WriteLine(score);
            ExtraScore(score);
            Console.WriteLine("the increase effect not applied anymore: " + score);
            Console.WriteLine("-------");
            Console.WriteLine("now we will use our ref");
            Console.WriteLine(score);
            ExtraScoreByRef(ref score);
            Console.WriteLine("the increase effect still existing: " + score);
        }

        public static void ExtraScore(int scorePram)
        {
            scorePram++;
            Console.WriteLine(scorePram);
        }

        public static void ExtraScoreByRef(ref int scorePram)
        {
            scorePram++;
            Console.WriteLine(scorePram);
        }

    }
}
