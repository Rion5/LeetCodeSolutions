using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// Given a sorted array 'nums', remove the duplicates in-place such that each element appear only once and return the new length.
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// IE) Input  :  nums = [1,1,2]
    ///     Output :  length = 2, with the first two elements of nums being 1 and 2
    /// </summary>
    public class RemoveDuplicatesFromSortedArray : Solution
    {
        private int[] _nums;

        public RemoveDuplicatesFromSortedArray(int[] nums)
        {
            _nums = nums;
        }

        private int removeDuplicates(int[] nums)
        {
            //Use 2 pointers, set i = 0, j = 0;
            //Loop through nums.Length - 1.
            //  Compare num[i] and num[i+1] (Compare the current element and the next)
            //      If they are NOT equal to each other, then this is the first occurrence of a new element, therefore we
            //          Set num[j] = nums[i] (which atm j = 0), then j++
            //      Else do nothing, since this is a duplicate. Go to the next iteration in the loop
            //At the end, set nums[j] = nums[nums.Length - 1] We do this to make sure to include the last element which is not a duplicate
            //return j
            if (nums.Length <= 0)
            {
                return 0;
            }
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j++] = nums[i];
                }
            }
            nums[j++] = nums[nums.Length - 1];
            return j;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = removeDuplicates(this._nums);
            watch.Stop();
            Console.WriteLine($"26. Remove Duplicates From a Sorted Array \n" +
                              $"Input String = {this.printInputArray(_nums)} \n" +
                              $"Longest SubString: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }

    }
}
