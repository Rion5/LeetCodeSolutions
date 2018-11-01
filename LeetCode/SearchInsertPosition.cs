using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class SearchInsertPosition :Solution
    {
        /** Problem: Search Insert Position
         *
         *  Given a sorted array and a taget value, return the index if the target is found. If not, rerun the index where it would be if it were inserted in order.
         *
         *  Example:
         *  Input:      [1, 3, 5, 6]    Target = 5
         *  Output :    2
         *  Explanation: Target '5' is found in the array at the index position 2
         */
        private int[] nums;
        private int target;

        public SearchInsertPosition(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
        }

        private int SearchInsert(int[] nums, int target)
        {
            //Brute Force:
            //Time Complexity:  O(2n) where n = number of elements in the array
            //Space Complexity: O(1)
            //Loop through each int in the array.
            //      If the number is found, return the index of the position in the array.
            //      Else, we need to return the index of where the number should be.
            //TODO: Consider negative inputs
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            //Number is not in the array, so we must find its correct intended position
            //I will loop through each number again, and find where [i-1] < target < [i+1]
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    if (nums[i - 1] < target && target < nums[i])
                    {
                        return i;
                    }
                }
            }
            return nums.Length;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = SearchInsert(this.nums, this.target);
            watch.Stop();
            Console.WriteLine($"35. Search Insert Position \n" +
                              $"Input String = [1, 3, 5, 6] Target = [{target}]\n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
