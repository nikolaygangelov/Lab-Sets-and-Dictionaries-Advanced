using System;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            int numberOfNames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNames; i++)
            {
                set.Add(Console.ReadLine());
            }
            Console.WriteLine("-------------");
            foreach (string name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
