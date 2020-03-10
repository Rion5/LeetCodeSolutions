using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 1342. Number of Steps to Reduce a Number to Zero
    /// Given a non-negative integer num, return the number of steps to reduce it to zero. If the current number is eve, you have to divide it by 2, otherwise you have to subtract 1 from it.
    /// IE) Input  :  num = 8
    ///     Output :  4
    /// Explanation:  Step 1) 8 is even; divide by 2, answer is 4
    ///               Step 2) 4 is even; divide by 2, answer is 2 [...]
    /// </summary>
    public class NumberOfStepsToReduceNumberToZero : Solution
    {
        private int number;
        public NumberOfStepsToReduceNumberToZero(int num)
        {
            this.number = num;
        }

        private int numberOfSteps(int num, int stepCounter = 0)
        {
            // While the number is not 0, check if it is an even or odd number.
            // If even, then divide and recursively recall the function
            // Otherwise, its odd, therefore subtract -1 and recursively recall the function
            if (num != 0)
            {
                stepCounter += 1;
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Step {stepCounter}) {num} is even; divide by 2 and get {num / 2}");
                    num /= 2;
                    return numberOfSteps(num, stepCounter);
  
                } 
                Console.WriteLine($"Step {stepCounter}) {num} is odd, subtract 1 and get {num - 1}"); 
                num -= 1;
                if (num == 0)
                {
                    return stepCounter;
                }
                return numberOfSteps(num, stepCounter);
            }
            return 0;
        }
        public override void PrintExample()
        {
            Console.WriteLine($"1342. Number of Steps to Reduce a Number to Zero \n" +
                              $"Input Num = {this.number}");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = numberOfSteps(this.number);
            watch.Stop();
            Console.WriteLine($"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
