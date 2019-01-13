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
            /*
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
            */
            int?[] memo = new int?[n+1];
            return fibMemoization(n, memo);
        }

        // Using Memoization to cache Fibonacci results
        // Improves Time Complexity from O(2^n) to O(n)
        private int fibMemoization(int n, int?[] memo)
        {
            // If the result has already been calculated, it will exist in the memo array.
            if (memo[n] != null) return (int) memo[n];
            int result = 0;
            if (n == 0) return result;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                result = fib(n - 1) + fib(n - 2);
                memo[n] = result;
            }
            return result;
        }

        private int fibBottomUp(int n)
        {
            // Time Complexity : O(n)
            // Space Complexity: O(n), where n is the input number
            // Base Cases
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            // Build the Fibonacci Sequence from left to right iteratively
            int[] bottomUp = new int[n + 1];
            bottomUp[1] = 1;
            bottomUp[2] = 1;
            for (int i = 3; i < bottomUp.Length; i++)
            {
                bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];
            }
            return bottomUp[n];
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = fibBottomUp(this.n);
            watch.Stop();
            Console.WriteLine($"509. Fibonacci Number\n" +
                              $"Input Num = {this.n} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
