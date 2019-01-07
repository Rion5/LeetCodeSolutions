using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 155. Min Stack
    /// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
    /// + push(x)  : Push element x onto stack
    /// + pop()    : Remove the element on top of the stack
    /// + top()    : Get the top element
    /// + getMin() : Retrieve the minimum element in the stack
    /// </summary>
    public class MinStack : Solution
    {
        private List<int> _data;

        public MinStack()
        {
            _data = new List<int>();
        }

        public void Push(int x)
        {
            _data.Add(x);
        }

        public void Pop()
        {
            _data.RemoveAt(_data.Count - 1);
        }

        public int Top()
        {
            return _data[_data.Count - 1];
        }

        public int GetMin()
        {
            return _data.Min();
        }

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            MinStack obj = new MinStack();
            obj.Push(2);
            obj.Push(-3);
            Console.WriteLine($"155. Min Stack\n" +
                              $"MinStack obj = new MinStack(); \n" +
                              $"obj.Push(2)\n" +
                              $"obj.Push(-3)\n" +
                              $"obj.Top()    : {obj.Top()}");
            obj.Pop();
            Console.WriteLine($"obj.Pop() \n" +
                              $"obj.GetMin() : {obj.GetMin()}");
            watch.Stop();
            Console.WriteLine($"Execution Speed: {watch.ElapsedMilliseconds}ms \n");

        }
    }
}
