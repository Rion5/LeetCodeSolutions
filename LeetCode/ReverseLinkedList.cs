using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    public class ReverseLinkedList : Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value) { this.val = value; }
        }

        private ListNode _head;

        public ReverseLinkedList(ListNode head)
        {
            this._head = head;
        }
        private ListNode reverseList(ListNode head)
        {
            // Time Complexity : O(n), where n is the length of the linked list
            // Space Complexity: O(1)
            ListNode previous = null;
            ListNode current = head;
            while (current != null)
            {
                // IE: 1 -> 2 -> 3 to
                //     3 -> 2 -> 1
                ListNode nextTemp = current.next;
                current.next = previous;
                previous = current;
                current = nextTemp;
            }
            return previous;
        }

        void printLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write($"{head.val} ");
                printLinkedList(head.next);
            }
        }

        public override void PrintExample()
        {

        }
    }
}
