using System;
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
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeating = new LongestSubstringWithoutRepeatingCharacters("abcdecb");
            longestSubstringWithoutRepeating.PrintExample();
            #endregion

            #region FizzBuzz
            //Problem: Wrie a program that outputs the string representation of numbers form 1 to n
            //For multiples of 3 it should output "Fizz"
            //For multiples of 5 it should output "Buzz"
            //For multiples of both it should output "FizzBuzz";
            FizzBuzz fizzBuzz = new FizzBuzz(15);
            fizzBuzz.PrintExample();
            #endregion

            #region Search Insert Position
            int[] arr = {1, 3, 5, 10};
            SearchInsertPosition searchInsertPosition = new SearchInsertPosition(arr,9);
            searchInsertPosition.PrintExample();
            #endregion

            #region Jewels and Stones
            string j = "aA", s = "aAAbbbb";
            JewelsAndStones jewelsAndStones = new JewelsAndStones(j, s);
            jewelsAndStones.PrintExample();
            #endregion
            Console.ReadLine();

        }
    }
}
