using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 412. FizzBuzz
    /// Write a program that outputs the string of numbers from 1 to n.
    ///  for multiples of three it should output "Fizz"
    ///  for multiples of five it should output  "Buzz"
    ///  for multiples of both it should output  "FizzBuzz"
    /// IE) Input:  n = 10
    ///     Output: ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
    /// </summary>
    public class FizzBuzz : Solution
    {
        private int n;
        public FizzBuzz(int n)
        {
            this.n = n;
        }

        private IList<string> fizzBuzz(int n)
        {
            //Goal: 
            //Loop through 0 - n and check if divisible by 3, 5, or both.
            // If one of the conditions is true
            //      Add the correct FizzBuzz word to the list
            // continue to skip the current forloops iteration
            //Time Complexity: O(n) where n is the number passed in
            //Space Complexity: 1
            string result = "";
            IList<string> list = new List<string>();
            //Loop through 0 - n and check if divisible by 3, 5, or both.
            for (int i = 1; i <= n; i++)
            {
                // Divisible by 3 & 5 = "FizzBuzz"
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "FizzBuzz";
                    list.Add(result);
                    continue;
                }
                // Divisible by 3 = "Fizz"
                if (i % 3 == 0)
                {
                    result = "Fizz";
                    list.Add(result);
                    continue;
                }
                // Divisible by 5 = "Buzz"
                if (i % 5 == 0)
                {
                    result = "Buzz";
                    list.Add(result);
                    continue;
                }

                result = i.ToString();
                list.Add(result);
            }
            return list;
        }
        public override void PrintExample()
        {
            Console.WriteLine($"412. Fizz Buzz");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = fizzBuzz(this.n);
            foreach (var number in results)
            {
                Console.WriteLine($"{number}");
            }
            watch.Stop();
            Console.WriteLine($"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
