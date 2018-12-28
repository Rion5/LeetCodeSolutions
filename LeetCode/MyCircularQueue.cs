using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 622. Design Circular Queue
    /// Design your implementation of the circular queue. The circular queue is a linear data structure in which the operations are performed based on FIFO (First In First Out) principle and the last position is connected back to the first position to make a circle. It is also called "Ring Buffer".
    /// IE) Input:  [1,2,3,1]
    ///     Output: true
    /// </summary>
    public class MyCircularQueue
    {
        private int _headPtr;
        private int _tailPtr;
        private int _size;
        private int[] _data;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            _size = k;
            _headPtr = -1;
            _tailPtr = -1;
            this._data = new int[_size];
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            if (IsEmpty())
            {
                _headPtr = 0;
            }
            _tailPtr = (_tailPtr + 1) % (_size);      // Move tailPtr up 1
            _data[_tailPtr] = value;
            Console.WriteLine($"EnQueue : {value}");
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            // If the _headPtr and _tailPtr are pointing to the same element, then this means that the _tailPtr has gone around the entire queue.
            // So we reset the pointers back to -1, this means that the Queue is 'empty'.
            // Technically the index may contain data, but for the purpose of a circular queue, it will be considered empty.
            if (_headPtr == _tailPtr)
            {
                _headPtr = -1;
                _tailPtr = -1;
                return true;
            }
            _headPtr = (_headPtr + 1) % (_size);      // Move headPtr up 1
            Console.WriteLine($"DeQueue : {_data[_tailPtr]}");
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _data[_headPtr];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _data[(_tailPtr + _size) % (_size)];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _headPtr == -1;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return (_tailPtr + 1) % (_size) == _headPtr;
        }
    }
}
