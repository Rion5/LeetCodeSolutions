using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class AddTwoNumbers : Solution
    {
        /** Problem: AddTwoNumbers
        *
        *  Given 2 non-empty singly-linked lists, containing 2 non-negative integers. The digits are stroed in reverse order and each of their nodes contain a single digit.
        *  Add the two numbers and return it as a linked list.
        *
        *  Example:
        *  Input:   (2 -> 4 -> 3) + (5 -> 6 -> 4)
        *  Output :  7 -> 0 -> 8
        *  Explanation: 342 + 465 = 807
        */
        public class ListNode
        {
            public int val;
            public ListNode nextNode;
            public ListNode(int x)
            {
                val = x;
            }
        }

        public ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            return null;
        }

        public override void PrintExample()
        {
            throw new NotImplementedException();
        }
    }
}
