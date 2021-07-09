using System;
using System.Diagnostics;
using System.Text;

/// <summary>
/// 2021.7.9
/// </summary>

namespace _014_benchmarks_StringBuilder_Replace
{
    const int MAX_SIZE = 1000000;
    static void Main()
    {
        var text = "bird, frog and dog";
        var s1 = Stopwatch.StartNew();
        //use string Replace.
        for (int i = 0; i < MAX_SIZE; i++)
        {
            string result = text;
            result = result.Replace("bird", "cat");
            result = result.Replace("frog", "fox");
            result = result.Replace("dog", "fish");
        }
        s1.Stop();
        var s2 = Stopwatch.StartNew();
        //use StringBuilder.
        for (int i = 0; i < MAX_SIZE; i++)
        {
            var builder = new StringBuilder(text);
            builder.Replace("bird", "cat");
            builder.Replace("frog", "fox");
            builder.Replace("dog", "fish");
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / MAX_SIZE).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / MAX_SIZE).ToString("0.00 ns"));
    }
}
