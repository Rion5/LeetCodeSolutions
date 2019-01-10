using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public abstract class Solution
    {
        public abstract void PrintExample();

        protected string printInputArray<T>(T[] input)
        {
            string result = "[ ";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                result += $"{input[i]} ";
            }
            result += "]";
            return result;
        }

        protected string print2DInputArray<T>(T[,] input)
        {
            string result = "";
            int rowLength = input.GetLength(0); // Gets the 1st dimension size [x, ]
            int colLength = input.GetLength(1); // Gets the 2nd dimension size [ ,x]
            for (int row = 0; row < rowLength; row++)
            {
                result += "[ ";
                for (int col = 0; col < colLength; col++)
                {
                    result += $"{input[row, col]} ";
                }
                result += "]\n";
            }
            //result.TrimEnd('\n');
            return result;
        }
    }
}
