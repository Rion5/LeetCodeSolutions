using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib.DataStructures
{
    public class Node
    {
        // Fields
        public int? Data;
        public Node Next;
        public Node Previous;

        // Constructors
        public Node(int value)
        {
            this.Data = value;
            this.Next = null;
            this.Previous = null;
        }
    }

    /// <summary>
    /// 707. Design Linked List
    /// Design your implemenation of the linked list. You can choose to use the singly linked list or the doubly lined list. A node in a singly linked list should have two attributes: val and next. Val is the value of the current node, next is a pointer/ reference to the next node. If you want to use the double linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.
    /// </summary>
    public class LinkedList
    {
        private Node _head;
        private Node _tail;

        public int Count = 0;
        
        // Constructors
        public LinkedList()
        {
            this._head = null;
            this._tail = null;
        }
        public LinkedList(Node head)
        {
            this._head = head;
            if (head.Next == null)
            {
                Count = 1;
            }
            while (head.Next != null)
            {
                this._tail = head.Next;
                Count++;
            }
        }

        //TODO: get(index), addAtHead(val), addAtTail(val), addAtIndex(index, val), deleteAtIndex(index)

        public void AddAtHead(int val)
        {

        }

        /// <summary>
        /// Append a node of values to the last element of the linked list.
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            try
            {
                Node node = _head;          // Set Node to first node in the list
                while (node.Next != null)   // Traverse to the end of LinkedList
                {
                    node = node.Next;
                }
                node.Next = new Node(val);  // Insert value at the end of the linked list   
                Count++;
            }
            catch
            {
                Console.WriteLine($"Error: Could not add '{val}' to Tail of Linked List");
            }
        }

        public void AddAtIndex(int index, int val)
        {

        }

        public void PrintLinkedList()
        {
            Console.WriteLine($"707. Design Linked List");
            Console.WriteLine($"Print Linked List");
            Console.Write($"HEAD => ");
            Node node = _head;
            if (node.Data == null && node.Next == null) return;  //Check if LinkedList is null & empty
            while (node.Data != null && node.Next != null)
            {
                Console.Write($"{node.Data} => ");
                node = node.Next;
            }
             
            if (node.Next == null)
            {
                Console.Write($"{node.Data} => TAIL\n\n");
            }
        }
    }
}
