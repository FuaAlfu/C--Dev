using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 2021.6.19
/// </summary>

/*
TODO
*/
namespace _002_out_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello out keyword!");
            //---------------------------------------
            int score;
            int sum;
            int mult;

            /*
           out keyword
           essentially does the same exact thing.. as [ref keyword]
           it allows us to pass a value type variable 
           by reference except it's slightly diffrent,
           there is one slight change..
           
           the change comes from a
           variable that we passing by reference
           does have a value or does not have a value
            */

            //we need two output parameters to hold the answers
            SumAndMult(100, 100, out sum, out mult);
            Console.WriteLine(sum);
            Console.WriteLine(mult);

            //----------------------------------------------------
            //for testing
            //Console.WriteLine(score);
            //ExtraScore(score);
            // Console.WriteLine("the increase effect not applied anymore: " + score);
            // Console.WriteLine("-------");
            // Console.WriteLine("now we will use our out keyword");
            // Console.WriteLine(score);
            // ExtraScoreByOut(out score);
            // Console.WriteLine("the increase effect still existing: " + score);
        }

        public static void SumAndMult(int x, int y, out int sum, out int mult)
        {
            sum = x + y;
            mult = x * y;
        }

        public static void ExtraScore(int scorePram)
        {
            scorePram++;
            Console.WriteLine(scorePram);
        }

        // public static void ExtraScoreByOut(out int scorePram)
        // {
        //out allows us to assign an initial value :: defined the variable inside here
        //we can return multiable values
        //     score = 0;
        //     scorePram++;
        //     Console.WriteLine(scorePram);
        // }
    }
}
