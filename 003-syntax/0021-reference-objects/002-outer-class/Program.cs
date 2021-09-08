using System;

namespace _002_outer_class
{
    class Program
    {
          static void Main(string[] args)
            {
                Person p1 = new Person("john",42);
                
                Console.WriteLine($"his name: {p1.Name} and his age about: {p1.Age}");
            }
    }
            //outer class
     public class Person
       {
         public string Name { get; set; }
         public int Age { get; set; }

         public Person(string name, int age)
         {
             this.Name = name;
             this.Age = age;
         }
       }
}
