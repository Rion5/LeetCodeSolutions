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
            input = input.Trim();
            // Base Cases
            if (String.IsNullOrEmpty(input) || !(Char.IsDigit(input[0]) || input[0] == '+' || input[0] == '-') ) { return 0; }

            string trimedString = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                trimedString += input[i];

                if (i + 1 < input.Length && !Char.IsDigit(input[i + 1]))
                {
                    break;
                }
            }

            if (trimedString == "+" || trimedString == "-")
            {
                return 0;
            }

            // Check if trimedString, when converted to an number, fits in Int32
            int number = 0;

            if (Int32.TryParse(trimedString, out number))
            {
                return number;
            }
            // otherwise the number is too big or small and we need to either return Int32.MaxValue or .MinValue
            else if (trimedString.Contains('-'))
            {
                return Int32.MinValue;
            }
            else
            {
                return Int32.MaxValue;
            }
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
