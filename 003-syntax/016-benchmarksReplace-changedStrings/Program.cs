using System;
using System.Diagnostics;
namespace _016_benchmarksReplace_changedStrings
{
    class Program
    {
        const int Max_Num = 1000000;
        static void Main()
        {
            string test = "alfu";
            var s1 = Stopwatch.StartNew();
            //Version 1: no change made.
            for (int i = 0; i < Max_Num; i++)
            {
                string result = test.Replace("z", "a");
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();


            //Version 2: changed string.
            for (int i = 0; i < Max_Num; i++)
            {
                string result = test.Replace("b", "a");
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / Max_Num).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / Max_Num).ToString("0.00 ns"));
        }
    }
}