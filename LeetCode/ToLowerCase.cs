using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 709. To Lower Case
    /// Implement function toLowerCase() that has a string parameter str, and returns a string in lowercase.
    /// IE) Input:  "LOVELY"
    ///     Output: "lovely"
    /// </summary>
    public class ToLowerCase : Solution
    {
        private string _inputString;

        public ToLowerCase(string inputString)
        {
            this._inputString = inputString;
        }

        private string toLowerCase(string str)
        {
            return str.ToLower();
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = toLowerCase(this._inputString);
            watch.Stop();
            Console.WriteLine($"709. To Lower Case\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
