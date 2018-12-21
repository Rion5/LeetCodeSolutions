using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 136. Single Number
    /// Given a NON-EMPTY array of integers, every element appears twice except for one. Find that single one
    /// Note: Algorithm should run in linear runtime compleixty. It is also possible to implement without using extra memory
    /// IE) Input  :  [2, 2, 3, 1, 3]
    ///     Output :  1
    /// Explanation:  1 is the element that only appears once
    /// </summary>
    public class SingleNumber : Solution
    {
        private int[] _nums;

        public SingleNumber(int[] nums)
        {
            this._nums = nums;
        }

        private int singleNumber(int[] nums)
        {
            // Hash Table Approach
            // Loop through all integers in nums array
            // if hashTable.Contains(integer), then pop off
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (hashSet.Add(nums[i]) == false && i > 0)
                {
                    // If the number was NOT added to the hashset then this means the number already exists in the hashset, so we remove it
                    hashSet.Remove(nums[i]);
                }
            }

            // By the end we should only have 1 integer in the hashSet, and this is the number that is Not a Duplicate
            foreach (var num in hashSet)
            {
                return num;
            }
            return -1;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = singleNumber(this._nums);
            watch.Stop();
            Console.WriteLine($"136. Single Number\n" +
                              $"Input Array = {this.PrintInputArray(_nums)} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
