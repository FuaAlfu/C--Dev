using System;
using System.Collections.Generic;

namespace _002_b
{
      class Program
    {
    static void Main(string[] args)
    {
        List<User> users = new List<User>()
        {
        new User() { Name = "John Doe", Age = 42 },
        new User() { Name = "fua alfu", Age = 29 },
        new User() { Name = "mua alfu", Age = 24 },
        };

        users.Sort(CompareUsers);
        foreach (User user in users)
        Console.WriteLine(user.Name + ": " + user.Age + " years old");
    }

    public static int CompareUsers(User user1, User user2)
    {
        return user1.Age.CompareTo(user2.Age);
    }
}
}
