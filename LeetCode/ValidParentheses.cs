using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 20. Valid Parentheses
    /// Given a string containing just the characters '( ) { } [ ]'. Determine if the input string is valid
    /// An input string is valid if:
    ///     1) Open brackets must be closed by the same type of brackets.
    ///     2) Open brackets must be closed in the correct order.
    /// IE) Input  :  "()[]{}"
    ///     Output :  true
    /// </summary>
    public class ValidParentheses : Solution
    {
        private string _inputString;

        public ValidParentheses(string s)
        {
            this._inputString = s;
        }

        private bool isValid(string s)
        {
            // Intent:
            // 1) Loop through each character in the stack
            // 2) If the element is an open bracket, Push it onto the stack.
            // 3) If we encounter a closing bracket, check the top element
            //      If the element at the top of the stack is an opening bracket of the same type, then we pop it off and continue the process, Else it is an invalid expression

            // Creating a Dictionary to assign key value pair with open and closed brackets
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            dictionary.Add('(', ')');
            dictionary.Add('{', '}');
            dictionary.Add('[', ']');
            // 1)
            for (int i = 0; i <= s.Length - 1; i++)
            {
                // 2)
                if (dictionary.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                // 3)
                if (dictionary.ContainsValue(s[i]) && stack.Count >= 1)
                {
                    // If the element at the top of the stack 
                    char topChar;
                    if (stack.TryPeek(out topChar) == true)
                    {
                        if (topChar == dictionary.FirstOrDefault(x => x.Value == s[i]).Key)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            // If there is an element on the stack, it is an invalid string.
            return stack.Count == 0;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = isValid(this._inputString);
            watch.Stop();
            Console.WriteLine($"20. Valid Parentheses\n" +
                              $"Input String = {this._inputString} \n" +
                              $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
