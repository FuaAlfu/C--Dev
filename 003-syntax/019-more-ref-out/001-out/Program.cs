using System;

namespace _001_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine(x);
            MyFunc(out x);
            Console.WriteLine(x);
        }

        static void MyFunc(out int v)
        {
            v = 9;
            Console.WriteLine(v);
        }
    }
}
