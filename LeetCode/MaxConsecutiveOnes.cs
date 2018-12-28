using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 485. Max Consecutive Ones
    /// Given a binary array, find the maximum number of consecutive 1s in this array.
    /// IE) Input:  [1,1,0,1,1,1]
    ///     Output: 3
    /// </summary>
    public class MaxConsecutiveOnes : Solution
    {
        private int[] _binaryArray;

        public MaxConsecutiveOnes(int[] nums)
        {
            this._binaryArray = nums;
        }

        private int findMaxConsecutiveOnes(int[] nums)
        {
            // Time Complexity : O(n), where n is the size of the array
            // Space Complexity: 1
            int consecutiveOnes = 0;
            int maxConsecutiveOnes = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == 1){
                    consecutiveOnes++;
                }
                else{
                    consecutiveOnes = 0;
                }

                if (consecutiveOnes > maxConsecutiveOnes){
                    maxConsecutiveOnes = consecutiveOnes;
                }
            }

            return maxConsecutiveOnes;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = findMaxConsecutiveOnes(this._binaryArray);
            watch.Stop();
            Console.WriteLine($"485. Max Consecutive Ones\n" +
                              $"Input Array = {printInputArray(this._binaryArray)} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
