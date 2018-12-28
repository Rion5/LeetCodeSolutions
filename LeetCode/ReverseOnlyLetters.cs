using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 917. Reverse Only Letters
    /// Given a string S, return the "reversed" string where all characters that are not a letter stay in the same place, and all letters reverse their positions.
    /// IE) Input:  "Test1ng-Leet=code-Q!"
    ///     Output: "Qedo1ct-eeLg=ntse-T!"
    /// </summary>
    public class ReverseOnlyLetters : Solution
    {
        private string _inputString;

        public ReverseOnlyLetters(string inputString)
        {
            this._inputString = inputString;
        }

        private string reverseOnlyLetters(string inputString)
        {
            // 1) Iterate through each char in the inputString
            //      if the char is a letter, push it onto a stack
            // 2) Iterate through, each char in the inputString
            //      if the char is a letter, pop the stack and append that char the results string
            //      otherwise it is not a letter and can be placed in the string directly
            // Time Complexity : O(n), where n is the length of inputString
            // Space Complexity: O(n)
            Stack<char> letters = new Stack<char>();
            foreach (char character in inputString)
            {
                if (Char.IsLetter(character))
                {
                    letters.Push(character);
                }
            }

            // 3)
            //StringBuilder result = new StringBuilder();
            string result = "";
            foreach (char character in inputString)
            {
                if (Char.IsLetter(character))
                {
                    //result.Append()
                    result += letters.Pop();
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = reverseOnlyLetters(this._inputString);
            watch.Stop();
            Console.WriteLine($"917. Reverse Only Letters\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
