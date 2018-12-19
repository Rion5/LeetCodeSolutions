using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 387. Contains Duplicates
    /// Given an array of integers, find if the array contains any duplicates.
    /// IE) Input:  [1,2,3,1]
    ///     Output: true
    /// </summary>
    public class ContainsDuplicate : Solution
    {
        private int[] _nums;

        public ContainsDuplicate(int[] nums)
        {
            this._nums = nums;
        }
        private bool containsDuplicates(int[] nums)
        {
            // If array is empty or only has 1 value, it is not a duplicate
            if (nums.Length <= 1)
            {
                return false;
            }

            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                // Check if current number can be added to the hashSet
                // If hashSet.Add == false, then there is a duplicate found.
                if (!hashset.Add(nums[i]))
                {
                    return true;
                }
                hashset.Add(nums[i]);
            }
            Console.WriteLine($"Hashset count: {hashset.Count} NumsArr length: {nums.Length}");
            return false;
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
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = containsDuplicates(this._nums);
            watch.Stop();
            Console.WriteLine($"217. Contains Duplicates\n" +
                              $"Input nums = [{this.printInputArray(this._nums)}] \n" +
                              $"Result: [{result}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
