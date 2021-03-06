using System;
using System.Collections.Generic;
using System.Linq;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .OrderByDescending(x => x)                
                .ToArray();

            int count = nums.Length >= 3 ? 3 : nums.Length; // ? thernal operator

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }        
    }
}
