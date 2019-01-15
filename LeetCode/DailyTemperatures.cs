using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 739. Daily Temperatures
    /// Given a list of daily temperatures 'T', return a list such that for each day in the input, tells you how many days you would have to wait until a warmer temperature.
    /// If there is no future day for which this is possible, put 0 instead.
    /// IE) Input  :  [73, 74, 75, 71, 69, 72, 76, 73]
    ///     Output :  [1, 1, 4, 2, 1, 1, 0, 0]
    /// </summary>
    public class DailyTemperatures : Solution
    {
        private int[] _temperatures;

        public DailyTemperatures(int[] T)
        {
            this._temperatures = T;
        }

        private int[] dailyTemperatures(int[] T)
        {
            // 1) Start from the end of the array and iterate backwards
            // 2) Check to see if the stack is empty,
            //      if true, push store the index on the stack, (we use the index to determine how many days between the current and next warmest day)
            //      else we set the result[i] to 0, indicating that the current index's value is the highest temp
            if (T.Length == 0)
            {
                return T;
            }
            int[] result = new int[T.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = T.Length - 1; i >= 0; i--)
            {
                // While stack is not empty, and the current element is >= the top of the stack, pop the value off
                while (stack.Count != 0 && T[i] >= T[stack.Peek()])
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = stack.Peek() - i;
                }
                stack.Push(i);
            }
            return result;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = dailyTemperatures(this._temperatures);
            watch.Stop();
            Console.WriteLine($"739. Daily Temperatures\n" +
                              $"Input String =  {printInputArray(this._temperatures)} \n" +
                              $"Result:         {printInputArray(results)} \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
