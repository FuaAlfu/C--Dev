using System;
using System.Diagnostics;

namespace _017_benchmarks_Replace_arguments
{
    class Program
    {
        const int Max_Num = 1000000;
        static void Main()
        {
            string test = "cat";
            var s1 = Stopwatch.StartNew();
            // Version 1: use char argument.
            for (int i = 0; i < Max_Num; i++)
            {
                string result = test.Replace('c', 'z');
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            // Version 2: use string argument.
            for (int i = 0; i < Max_Num; i++)
            {
                string result = test.Replace("c", "z");
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / Max_Num).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / Max_Num).ToString("0.00 ns"));
        }
    }
}
