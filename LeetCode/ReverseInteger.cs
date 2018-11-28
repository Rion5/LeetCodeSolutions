using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 7. Reverse Integer
    /// Given a 32-bit signed integer, reverse digits of an integer.
    /// IE) Input:  -123
    ///     Output: -321
    /// </summary>
    public class ReverseInteger : Solution
    {
        private int _num;
        public ReverseInteger(int num)
        {
            _num = num;
        }

        private int reverseInteger(int num)
        {
            //Convert integer to string
            //IE - 123 => "123"
            string numToString = num.ToString();
            string reversedString = "";
            bool isNegative = false;

            //Check if integer is negative.
            if (num < 0)
            {
                reversedString += "-";
                isNegative = true;
            }

            if (isNegative)
            {
                for (int i = numToString.Length - 1; i > 0; i--)
                {
                    reversedString += numToString[i];
                }
            }
            else
            {
                for (int i = numToString.Length - 1; i >= 0; i--)
                {
                    //Console.Write($"{numToString[i]}");
                    reversedString += numToString[i];
                }
            }

            //Checking for Overflow
            int results = 0;
            try
            {
                results = Convert.ToInt32(reversedString);
            }
            catch (Exception)
            {
                return 0;
            }
            return results;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = reverseInteger(this._num);
            watch.Stop();
            Console.WriteLine($"7. Reverse Integer\n" +
                              $"Input num = {this._num} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
