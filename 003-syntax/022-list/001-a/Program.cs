using System;
using System.Collections.Generic;

/// <summary>
/// 2021.9.7
/// </summary>

namespace _001_a
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> users = new List<string>();

           users.Add("user1");
           users.Add("user2");
           Console.WriteLine(users);

           //Listing 
           // Collection of string  
           string[] usersGroup = { "user3", "user4", "user5" };    
            
           users.AddRange(usersGroup);  
           //range over a list of users
          foreach (string u in users)
          {  
           Console.WriteLine(u); 
          }
          System.Console.WriteLine("====");

           //remove an element from the list
           users.Remove("user1");
           foreach (string u in users)
           Console.WriteLine(u); 
          }
    }
}
