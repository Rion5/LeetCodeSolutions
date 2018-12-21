using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 747. Largest Number At Least Twice of Others
    /// In a given integer array, there is always exactly 1 largest element.
    /// Find whether the largest element in the array is at least twice as much as every other number in the array.
    /// Return the index of the largest element, otherwise return -1
    /// IE)   Input:  nums = [3, 6, 1, 0]
    ///      Output:  1
    /// Explanation:  6 is the largest int and for every other num in the array, 6 is more than 2x as big. The index of value is 6, so we return 1
    /// </summary>
    public class LargestNumberAtLeastTwiceOfOthers : Solution
    {
        private int[] _nums;

        public LargestNumberAtLeastTwiceOfOthers(int[] nums)
        {
            this._nums = nums;
        }
        private int DominantIndexBruteForce(int[] nums)
        {
            // Brute Force:
            // 1) Loop through the array and find the largest number
            // 2) Loop through again and see if the currennum * 2 < largestNum
            // Time Complexity : O(n), n = num of elements in array
            // Space Complexity: 1
            int largestNum = -1;
            int indexPosition = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > largestNum)
                {
                    largestNum = nums[i];
                    indexPosition = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 2 > largestNum && nums[i] != largestNum)
                {
                    return -1;
                }
            }

            return indexPosition;
        }

        private string printInputArray(int[] nums)
        {
            string result = "";
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                result += $"{nums[i]} ";
            }

            return result;
        }

        public override void PrintExample()
        {
            string array = printInputArray(this._nums);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = DominantIndexBruteForce(this._nums);
            watch.Stop();
            Console.WriteLine($"747. Largest Number At Least Twice of Others\n" +
                              $"Input Array = {array} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }

    }
}
