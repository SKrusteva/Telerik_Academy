using System;
using System.Collections.Generic;

namespace _08.Events
{
    /* 08*. (Read in MSDN about the keyword event in C# and how to publish events.
            Re-implement the above using .NET events and following the best practices.) */
    class EventsTest
    {
        static string[] name = new string[] {"Angel", "Boris", "Vasilena", "Gergana", "Dimitar", "Emil", 
            "Jana", "Iva", "Joan", "Kiril", "Lilia", "Maria", "Nicolai", "Orhan", "Petia", "Reneta", "Stefan"};
        
        static void Main()
        {
            Department cs = new Department();
            Random rnd = new Random();
            List<Student> present = new List<Student>();
            for (int i = 0; i < 13; i++)
            {
                string studName = name[rnd.Next(0, 16)];
                int fn = int.Parse(string.Concat("12", rnd.Next(3150, 4217)));
                Student next = new Student(studName, fn, cs);
                if (!present.Contains(next))
                {
                    present.Add(next);
                }
            }

            cs.Announce();
            Console.WriteLine("List of present students:");
            foreach (Student man in present)
            {
                Console.WriteLine(string.Join(", ", man.Name, man.FacultyNumber));
            }
        }
    }
}
