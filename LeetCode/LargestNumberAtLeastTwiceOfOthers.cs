using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private int dominantIndexBruteForce(int[] nums)
        {
            // Brute Force:
            // 1) Loop through the array and find the largest number
            // 2) Loop through again and see if the currennum * 2 < largestNum
            // Time Complexity : O(2n) => O(n), n = num of elements in array
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

        private int dominantIndex(int[] nums)
        {
            // 1) Loop through the aray and find the largestNumber, store the indexPosition
            int maxValue = nums.Max();
            int maxValueIndex = nums.ToList().IndexOf(maxValue);

            // 2) Sort the Array
            Array.Sort(nums);

            // 3) Check if num[nums.Length - 2] * 2 >= nums.Length - 1
            //      | Here we are checking the 2nd to last index in the array, since the last index should be the highest number
            //      | IE: [0, 1, 3, 6]    Check if (3 * 2) <= 6
            //    If true, return the maxValueIndex, otherwise return -1
            if (nums[nums.Length - 2] * 2 <= nums[nums.Length - 1])
            {
                return maxValueIndex;
            }
            return -1;
        }

        public override void PrintExample()
        {
            string array = this.PrintInputArray(this._nums);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = dominantIndex(this._nums);
            watch.Stop();
            Console.WriteLine($"747. Largest Number At Least Twice of Others\n" +
                              $"Input Array = {array} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
            dominantIndex(this._nums);
        }

    }
}
