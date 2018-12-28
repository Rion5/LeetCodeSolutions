using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 268. Missing Number
    /// Given an array containing n distinct numbers from 0 to n. Find the one that is missing from the array
    /// IE) Input:  [3, 0, 1]
    ///     Output: 2
    /// </summary>
    public class MissingNumber : Solution
    {
        private int[] _nums;
        public MissingNumber(int[] nums)
        {
            this._nums = nums;
        }

        private int missingNumber(int[] nums)
        {
            // 1) Sort the Array
            // 2) Iterate through nums array, find the missing digit
            // Time Complexity: O(n log n) to sort and find missing number, where n = the size of the array.
            // Space Complexity: 1

            Array.Sort(nums);
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }
            return nums.Length;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = missingNumber(this._nums);
            watch.Stop();
            Console.WriteLine($"268. Missing Number\n" +
                              $"Input Array = {printInputArray(this._nums)} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
