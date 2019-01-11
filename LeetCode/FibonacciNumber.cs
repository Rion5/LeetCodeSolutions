using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 509. Fibonacci Number
    /// The Fibonacci numbers, commonly denoted to F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of two preceeding ones, start from 0 and 1.
    /// IE) Input  :  [4]
    ///     Output :  [3]
    /// Explanation:  F(4) = F(3) + F(2) ==> 2 + 1 = 3
    /// </summary>
    public class FibonacciNumber : Solution
    {
        private int n;

        public FibonacciNumber(int n)
        {
            this.n = n;
        }

        private int fib(int n)
        {
            // Base cases
            int result = 0;
            if (n == 0) return result;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            // Otherwise use recursion to calculate the Fibonacci Number
            else
            {
                result = fib(n - 1) + fib(n - 2);
            }
            return result;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = fib(this.n);
            watch.Stop();
            Console.WriteLine($"509. Fibonacci Number\n" +
                              $"Input Num = {this.n} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
