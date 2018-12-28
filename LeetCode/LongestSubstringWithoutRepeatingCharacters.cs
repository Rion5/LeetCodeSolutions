using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 3. Longest Substring Without Repeating Characters
    /// Given a string, find the length of the longest substring without repeating characters
    /// IE) Input  :  "abccbb"
    ///     Output :  3
    /// Explanation:  "abc" has a length of 3
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters : Solution
    {

        private string _inputString = "";
        public LongestSubstringWithoutRepeatingCharacters(string inputString)
        {
            this._inputString = inputString;
        }
        private int LengthOfLongestSubstring(string inputString)
        {
            //Goal:
            //0)    Check for strings of only size 0-1
            //1)    Create an empty hashSet
            //2)    Loop through each char of the passed in 'inputString'
            //3)    Check if the hashSet does not contains the char
            //          Add to hashSet
            //4)    If the hashSet already contains the current char,
            //      Increment the Pointer to the next letter,
            //      Reset arrayIndex (i) back to the pointer
            //      Clear the hashSet and repeat process
            //Note: Performance could be improved because we rebuild the hashSet multiple times
            if (inputString.Length == 0)
            {
                return 0;
            }
            if (inputString.Length == 1)
            {
                return 1;
            }

            int i = 0;
            int pointer = 0;
            int maxSubstring = 0;
            HashSet<string> hashSet = new HashSet<string>();
            while (i < inputString.Length && pointer < inputString.Length)
            {
                if (!hashSet.Contains(inputString[i].ToString()))
                {
                    hashSet.Add(inputString[i++].ToString());
                }
                else
                {
                    if (hashSet.Count > maxSubstring)
                    {
                        maxSubstring = hashSet.Count;
                    }
                    pointer++;
                    i = pointer;
                    hashSet.Clear();
                }
            }
            if (hashSet.Count > maxSubstring)
            {
                maxSubstring = hashSet.Count;
            }
            return maxSubstring;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = LengthOfLongestSubstring(this._inputString);
            watch.Stop();
            Console.WriteLine($"3. Longest Substring Without Repeating Characters \n" +
                              $"Input String = {this._inputString} \n" +
                              $"Longest SubString: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
