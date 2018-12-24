using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 125. Valid Palindrome
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// IE) Input:  "A man, a plan, a canal: Panama"
    ///     Output: true
    /// </summary>
    public class ValidPalindrome : Solution
    {
        private string _inputString;

        public ValidPalindrome(string inputString)
        {
            this._inputString = inputString;
        }

        private bool isPalindrome(string inputString)
        {
            // Regex to only consider alphanumeric chars
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            inputString = rgx.Replace(inputString.ToLower(), "");

            // Compare each chars from the start and end
            //  If its a palindrome then the characters should be the same.
            int counter = inputString.Length - 1;
            for (int i = 0; i <= inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[counter--])
                {
                    return false;
                }
            }
            return true;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = isPalindrome(this._inputString);
            watch.Stop();
            Console.WriteLine($"125. Valid Palindrome\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
