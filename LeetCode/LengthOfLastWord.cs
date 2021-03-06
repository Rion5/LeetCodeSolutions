﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 58. Length of Last Word
    /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
    /// IE) Input  :  "Hello World"
    ///     Output :  5
    /// </summary>
    public class LengthOfLastWord : Solution
    {
        private string _inputString;

        public LengthOfLastWord(string inputString)
        {
            this._inputString = inputString;
        }

        private int lengthOfLastWord(string inputString)
        {
            // Special Case: Trim White Spaces at the end of the word
            // Separate string by space, Get Last Word's Length
            return inputString.TrimEnd().Split(' ').Last().Length;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = lengthOfLastWord(this._inputString);
            watch.Stop();
            Console.WriteLine($"58. Length of Last Word\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
