using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public abstract class Solution
    {
        public abstract void PrintExample();

        protected string printInputArray(int[] nums)
        {
            string result = "";
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                result += $"{nums[i]} ";
            }

            return result;
        }

        protected string printInputArray(string[] input)
        {
            string result = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                result += $"{input[i]} ";
            }

            return result;
        }
    }
}
