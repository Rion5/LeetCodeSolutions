using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 167. Two Sum II - Input Array is sorted
    /// Given an array of inegers that is already sorted in ascending order, find 2 numbers such that they add up to a specific target number.
    /// The function twoSum should return indices of the 2 numbers such that they add up to the target, where index1 must be less than index2.
    /// IE) Input  :  numbers = [2,7,11,15], target = 9
    ///     Output :  [1,2]
    /// Explanation:  The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
    /// NOTE: Your returned answers (both index1 and index2) are NOT zero-based.
    /// </summary>
    public class TwoSumII : Solution
    {
        private int[] _numbers;
        private int _target;

        public TwoSumII(int[] numbers, int target)
        {
            this._numbers = numbers;
            this._target = target;
        }

        private int[] twoSum(int[] numbers, int target)
        {
            // 2 pointers, 1 at the start and 1 at the end. 
            // If left + right == target, return indices
            // If left + right > target, move the right pointer to the left 
            //    (since array is sorted in order, if the summed value is greater than the target move to the left)
            // Time Complexity : O(n), where n is the number of intergers in the numbers array
            // Space Complexity: 1
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    //Note: +1 because the problem said the returned answers are NOT 0 based
                    return new int[2] {left + 1, right + 1};
                }

                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            throw new Exception("No answer found");
        }

        private int[] twoSumUsingDictionary(int[] numbers, int target)
        {
            // Iterate through the numbers array
            //  foreach number, find its complement so that curNumber + complement == target, store it into the hashmap if it doesn't exist.
            // Time Complexity : O(n)
            // Space Complexity: O(n), where n is the number of integers in the array
            Dictionary<int, int> dictionary = new Dictionary<int, int>();   //<key><value> ==> <number's Complement> <number's index in array>
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int complement = target - numbers[i];
                //[2, 7, 10] T = 9
                if (dictionary.ContainsKey(complement))    //if dictionary.Contains (9-2 => 7)
                {
                    return new[]
                    {
                        dictionary[complement] + 1, i + 1
                    };
                }
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(numbers[i], i);
                }
            }
            throw new Exception();
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = twoSum(this._numbers, this._target);
            watch.Stop();
            Console.WriteLine($"167. Two Sum II - Input array is sorted\n" +
                              $"Input String =  {printInputArray(this._numbers)} Target = {this._target} \n" +
                              $"Result:         {printInputArray(results)} \n" +
                              $"Execution Speed: {watch.ElapsedTicks} ticks \n");
        }
    }
}
