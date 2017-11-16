using System;
using System.Collections.Generic;

namespace LiveCodeClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("bob");
            names.Add("susan");

            foreach (string name in names)
            {
                if (name.Length == 5)
                {
                    Console.WriteLine(names);
                }
            }

            if (names.Contains("bob"))
            {
                // do something later
            }
            else if (names.Count > 5)
            {
                // do something else
            }
            else if (names.IndexOf("bob") == 0)
            {
                // finally more stuff
            }
        
            var students = new Dictionary<string, int>();
            students.Add("ernie", 99);
            students.Add("ziki", 92);

            foreach(var name in students.Keys)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
