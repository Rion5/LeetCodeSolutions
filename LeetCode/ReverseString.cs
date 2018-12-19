using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 344. Reverse String
    /// Write a function that takes a string as input and returns the string reversed.
    /// IE) Input:  "hello"
    ///     Output: "olleh"
    /// </summary>
    public class ReverseString : Solution
    {
        private string _inputString;

        public ReverseString(string inputString)
        {
            this._inputString = inputString;
        }

        private string reverseString(string inputString)
        {
            // Loop backwards from the end of the string.
            // Time Complexity : O(n) 
            // Space Complexity: O(n) where n is the length of the inputString
            var reverse = inputString.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);


            /* Passes 475/476 Test Cases: Time Limit Exceeded
            if (inputString.Length<=1)
            {
                return _inputString;
            }

            string reversedString = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }
            return reversedString;
            */
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = reverseString(this._inputString);
            watch.Stop();
            Console.WriteLine($"344. Reverse String\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
