using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 9. Palindrome Number
    /// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backwards as forward.
    /// IE) Input  :  -121
    ///     Output :  false
    /// Explanation:  From left to right, it reads -121. From right to left, it reads 121-. Therefore it is NOT a palindrome.
    /// </summary>
    public class PalindromeNumber : Solution
    {
        private int _num;

        /// <summary>
        /// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backwards as forward.
        /// </summary>
        /// <param name="num"></param>
        public PalindromeNumber(int num)
        {
            this._num = num;
        }

        // Time Complexity:  O(2n), n == number of digits in integer. Because we have to do a 2 loops, 1 for pushing and 1 for popping.
        // Space Complexity: O(n),  n == number of digits in integer. This is because we need to create a stack with enough space for each digit.
        private bool isPalindrome(int num)
        {
            // 1) Create a stack and push each digit onto the stack.
            // 2) At the end, pop each number off the stack
            //    see if resulting numbers reads the same forwards and backwards

            if (num < 0)
            {
                return false;
            }

            // 1)
            string numToString = num.ToString();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i <= numToString.Length - 1; i++)
            {
                //Console.WriteLine($"Stack Push: {numToString[i]}");
                stack.Push(numToString[i]);
            }
            
            // 2)
            string result = "";
            for (int i = 0; i <= numToString.Length - 1; i++)
            {
                //Console.WriteLine($"Stack Pop: {stack.Peek()}");
                result += stack.Pop();
            }

            return result == numToString;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = isPalindrome(this._num);
            watch.Stop();
            Console.WriteLine($"9. Palindrome Number\n" +
                              $"Input Number = {this._num.ToString()}\n" +
                              $"Result: {results} \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
