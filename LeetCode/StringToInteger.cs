using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class StringToInteger : Solution
    {
        private string _input;

        public StringToInteger(string input)
        {
            this._input = input;
        }

        private int stringToInteger(string input)
        {
            // Base cases
            // Return 0 if string is null, or starts with a letter
            input = input.Trim();
            if (String.IsNullOrEmpty(input)) return 0;
            char[] charArray = input.ToCharArray();
            if (!Char.IsNumber(charArray[0]) || charArray[0] == '-') return 0;

            bool neg = false || charArray[0] == '-';

            // Build string if char is a num between (0-9)
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (Char.IsNumber(charArray[i]))
                {
                    number.Append(charArray[i]);
                }

                if (!Char.IsNumber(charArray[i]))
                {
                    break;
                }
            }

            if (number.Length >= 10)
            {
                return neg ? int.MinValue : int.MaxValue;
            }

            // Convert string to double and
            //     check for extra conditionals, as asked in the problem
            long result;
            try
            {
                result = Convert.ToInt64(number.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
            if (neg)
            {
                result *= -1;
            }


            return (int)result;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = stringToInteger(this._input);
            watch.Stop();
            Console.WriteLine($"8. String to Integer (atoi) \n" +
                              $"Input String = {this._input}\n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
