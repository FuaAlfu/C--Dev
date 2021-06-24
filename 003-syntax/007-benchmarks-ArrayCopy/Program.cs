using System;
using System.Diagnostics;

/// <summary>
/// 2021.6.24
/// </summary>

/*
TODO
*/
namespace _007_benchmarks_ArrayCopy
{
    class Program
    {
        const int _MAX_VAL = 10000000;
        static void Main(string[] args)
        {
            //Set up benchmark.
            var data = new byte[200];
            for (int i = 50; i < 75; i++)
            {
                data[i] = (byte)i;
            }
            var buffer = new byte[100];
            var s1 = Stopwatch.StartNew();

            //use Array.Copy ::  This version of the code copies 25 array elements with Array.Copy. The elements are single bytes.
            for (int i = 0; i < _MAX_VAL; i++)
            {
                Array.Copy(data, 50, buffer, 0, 25);
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();

            //use for-loop to copy :: This code uses a for-loop to copy each of the 25 elements—it uses array element assignment.
            for (int i = 0; i < _MAX_VAL; i++)
            {
                for (int z = 0; z < 25; z++)
                {
                    buffer[z] = data[z + 50];
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _MAX_VAL).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _MAX_VAL).ToString("0.00 ns"));
        }
    }
}
