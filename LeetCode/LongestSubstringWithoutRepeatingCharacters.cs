using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class LongestSubstringWithoutRepeatingCharacters : Solution
    {
        /** Problem: Longest Substring Without Repeating Characters
         *
         *  Given a string, find the length of the longest substring without reapting characters
         *
         *  Example: "abccbb"
         *  Output : 3
         *  Explanation: "abc" has a length of 3
         */
        private string inputString = "";
        public LongestSubstringWithoutRepeatingCharacters(string inputString)
        {
            this.inputString = inputString;
        }
        private int LengthOfLongestSubstring(string inputString)
        {
            //Goal:
            //0)    Check for strings of only size 1
            //1)    Create an empty hashTable
            //2)    Loop through each char of the passed in 'inputString'
            //3)    Check if the hashTable contains the char
            //        if true, then we have a repeating character so we
            //          set highestCounter, clear hashTable, reset counter
            //        else continue to add the letter to the hashTable and increment counter
            //4)    Return highestCounter (highestCounter == max Length of non repeating substring)
            if (inputString.Length == 1)
            {
                return 1;
            }
            Hashtable hashtable = new Hashtable();
            int counter = 0;
            int highestCounter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (hashtable.ContainsKey(inputString[i]))
                {
                    //counter++;
                    if (highestCounter <= counter)
                    {
                        highestCounter = counter;
                    }
                    hashtable.Clear();
                    counter = 0;
                }
                hashtable.Add(inputString[i], i); //(key, value) == (charOfString, arrayIndex)
                counter++;
            }
            //if highestCounter == 0, this means there were no repeating chars found, so return the entire string length
            return highestCounter;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = LengthOfLongestSubstring(this.inputString);
            watch.Stop();
            Console.WriteLine($"3. Longest Substring Without Repeating Characters \n" +
                              $"Input String = {this.inputString} \n" +
                              $"Longest SubString: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
