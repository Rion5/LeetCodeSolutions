﻿using System;
using LeetCodeSolutionsLib;

namespace LeetCodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Two Sum
            //Problem: Given a array of ints, return indices of 2 numbers when summed together add to the target value
            //       - Using a Hashtable or Dictionary we can get the following complexity
            //Time Complexity:  O(n)
            //Space Complexity: O(n)
            TwoSums twoSums = new TwoSums(new int[] {2, 7, 11, 15}, 18);
            twoSums.PrintExample();
            #endregion

            #region LongestSubstringWithoutRepeatingCharacters
            //Problem: Given 2 non-empty linked lists where the digits are stroed in reverse order (each node can contain a single digit). 
            //         Add the 2 numbers and return it as a linked list
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeating = new LongestSubstringWithoutRepeatingCharacters("chaiabccccbchai");
            longestSubstringWithoutRepeating.PrintExample();
            #endregion
            Console.ReadLine();

        }
    }
}
