using System;

namespace _002_ref
{
    class Program
    {
          static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);
            MyDoubleFunc(ref x);
            Console.WriteLine(x);
        }

        static void MyDoubleFunc(ref int v)
        {
            v = v * 2;
            Console.WriteLine(v);
        }
    }
}
