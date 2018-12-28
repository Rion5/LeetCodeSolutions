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
    }
}
