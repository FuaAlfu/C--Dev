using System;

namespace _001_inner_class
{
    class Program
    {
           static void Main(string[] args)
            {
                Person p = new Person();
                p.name = "john doe";
                p.age = 42;
                Console.WriteLine($"his name: {p.name} and his age about: {p.age}");
            }

             //inner class
       class Person
       {
         public string name;
         public int age;
       }
    }
}
