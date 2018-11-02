using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class JewelsAndStones : Solution
    {
        /** Problem: Jewels and Stones
        *
        *  You're given strings J representing the types of stones that are jewels, and S representing the stones you have. Each char in S is a type of stone you have. You want to know how many of the stones you have are also jewels.
        *
        *  Example:
        *  Input:       J =  "abbC"    S = "aAbBcC"
        *  Output :     2
        *  Explanation: string 'S' only contains chars 'a' and 'C' from J
        */
        private string j;
        private string s;

        public JewelsAndStones(string J, string S)
        {
            j = J;
            s = S;
        }

        private int NumJewlsInStones(string J, string S)
        {
            //Intent: We have 2 strings, J, S. We want to know how many times a char from J is found in S
            //1) Loop through S.Length using i counter
            //2) Loop through J.Length using j counter
            //3)      Loop through each char in the longer string, using a j counter
            //          if shorterString[i] == longerString[j] 
            //              counter++
            //4) Return counter || 0;
            //Time Complexity: O(n^2)
            //Space Complexity: 1
            int counter = 0;
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < J.Length; j++)
                {
                    if (J[j] == S[i])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = NumJewlsInStones(this.j, this.s);
            watch.Stop();
            Console.WriteLine($"771. Jewels and Stones \n" +
                              $"Input String = J = '{j}' S = '{s}'\n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
