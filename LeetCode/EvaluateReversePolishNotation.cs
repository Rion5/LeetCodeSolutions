using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 150. Evaluate Reverse Polish Notation
    /// Evaluate the value of an arithmetic expression in Reverse Polish Notation
    /// Valid Operators are + - * /
    /// IE) Input  :  ["2", "1", "+", "3", "*"]
    ///     Output :  9
    /// Explanation:  ((2 + 1) * 3) = 9
    /// </summary>
    public class EvaluateReversePolishNotation : Solution
    {
        private string[] _inputString;

        public EvaluateReversePolishNotation(string[] tokens)
        {
            this._inputString = tokens;
        }

        private int evaluateReversePolishNotation(string[] tokens)
        {
            // Using a Stack, loop through each string in 'tokens' array
            // 1) If element is a number, push it on top the stack
            // 2) If element is an operator, pop two numbers from the stack, do the correct calculations and push back the results.
            // Time Complexity : O(n) where n is the size of the token's array
            // Space Complexity: O(n)
            string validOperators = "+-*/";
            Stack<int> stack = new Stack<int>();
            int number = 0;
            foreach (var element in tokens)
            {
                // 1)
                if (int.TryParse(element, out number))
                {
                    stack.Push(number);
                }
                // 2)
                else
                {
                    int rightValue = stack.Pop();
                    int leftValue = stack.Pop();
                    int operatorIndex = validOperators.IndexOf(element);
                    // Console.WriteLine($"{leftValue} {element.ToString()} {rightValue}");
                    switch (operatorIndex)
                    {
                        case 0:
                            stack.Push(leftValue + rightValue);
                            break;
                        case 1:
                            stack.Push(leftValue - rightValue);
                            break;
                        case 2:
                            stack.Push(leftValue * rightValue);
                            break;
                        case 3:
                            stack.Push(leftValue / rightValue);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = evaluateReversePolishNotation(this._inputString);
            watch.Stop();
            Console.WriteLine($"150. Evaluate Reverse Polish Notation\n" +
                              $"Input String = {printInputArray(this._inputString)} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
