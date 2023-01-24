using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            numbers = numbers.OrderByDescending(n => n)
                .ToArray();
            if (numbers.Length < 3)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers.Take(3)));
            }
        }
    }
}
