using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 387. First Unique Character in a String
    /// Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1
    /// IE) Input:  "loveleetcode"
    ///     Output: 2
    /// </summary>
    public class FirstUniqueCharacterInAString : Solution
    {
        private string _inputString;

        public FirstUniqueCharacterInAString(string inputString)
        {
            this._inputString = inputString;
        }

        private int firstUniqueChar(string inputString)
        {
            // Loop through each character in the string
            // Store each char in a Dictionary, the <key, value> == <char, # of times char appears in string>
            // Loop through each char in the string again, and check if the dictionary value for that char is = 1
            // Return the index of that letter in the string, because that is the first non repeated or first unique char in the string
            // Time Complexity: O(2n) => O(n) where n is the number of chars in the string.
            //  This is because we have to loop through the string once to create the dictionary, another time to check for the first char where the dictionary value == 1
            // Space Complexity: O(1) it is constant space because no matter what the length of the string, we only need to store enough chars in the alphabet. It would still be constant space for different languages, the dictionary size may increase, but there is a finite possible amount of unique characters in a language.
            int currentCount;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (char c in inputString)
            {
                // currentCount will be 0 if the char does not exist in the dictionary
                dictionary.TryGetValue(c, out currentCount);
                dictionary[c] = ++currentCount;    //Increment currentCount first, then use it
            }

            foreach (char c in inputString)
            {
                if (dictionary[c] == 1)
                {
                    return inputString.IndexOf(c);
                }
            }
            return -1;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = firstUniqueChar(this._inputString);
            watch.Stop();
            Console.WriteLine($"387. First Unique Character in a String\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
