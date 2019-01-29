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

        // Constructors
        public Node()
        {
            this.Data = null;
            this.Next = null;
        }
        public Node(int value)
        {
            this.Data = value;
            this.Next = null;
        }
    }

    /// <summary>
    /// 707. Design Linked List
    /// Design your implementation of the linked list. You can choose to use the singly linked list or the doubly lined list. A node in a singly linked list should have two attributes: val and next. Val is the value of the current node, next is a pointer/ reference to the next node. If you want to use the double linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.
    /// </summary>
    public class LinkedList
    {
        private Node _head;
        private Node _tail;

        public int Count;
        
        // Constructors
        public LinkedList()
        {
            this._head = new Node();
            this._tail = null;
            this.Count = 0;
        }

        //TODO: get(index), addAtIndex(index, val), deleteAtIndex(index)

        /// <summary>
        /// Append a node to the front of the linked list
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            // If LinkedList is empty, set both the head and tail to this node
            // Else set the current list to the nodeToAdd'.Next and move the nodeToAdd to the front (head) of the LinkedList
            Node nodeToAdd = new Node(val);
            if (_head.Data == null)
            {
                _head = nodeToAdd;
                _tail = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = _head;
                _head = nodeToAdd;
            }
            Count++;
        }

        /// <summary>
        /// Append a node the end of the linked list.
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            // If LinkedList is empty, add node to the head and exit out of function
            if (_head.Data == null)
            {
                AddAtHead(val);
                return;
            }
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

            if (index < 0) return;

            // If LinkedList is empty, add node to the front
            if (_head.Data == null)
            {
                AddAtHead(val);
                return;
            }

            //If index is out of range of LinkedList, add node to the tail
            if (index > Count)
            {
                AddAtTail(val);
                return;
            }

            // Iterate to the index and insert

        }

        public void PrintLinkedList()
        {
            Node node = _head;
            if (node.Data == null && node.Next == null) return;  //Check if LinkedList is null & empty

            Console.WriteLine($"707. Design Linked List");
            Console.WriteLine($"Print Linked List");
            Console.Write($"HEAD => ");

            // Iterate through each node, printing its value
            while (node.Data != null && node.Next != null)
            {
                Console.Write($"{node.Data} => ");
                node = node.Next;
            }

            // End of Linked List
            if (node.Next == null)
            {
                Console.Write($"{node.Data} => TAIL\n\n");
            }
        }
    }
}
