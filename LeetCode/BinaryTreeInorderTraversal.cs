using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 94. Binary Tree Inorder Traversal
    /// Given a binart tree, return the inorder traversal of its nodes' values.
    /// IE) Input  :  [1, null, 2, 3]
    ///     Output :  [1, 3, 2]
    /// Explanation:  1
    ///             /   \
    ///            *     2
    ///                 /  \
    ///                3
    /// </summary>
    public class BinaryTreeInorderTraversal : Solution
    {
        // Definition for a binary tree node
        private class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            {
                val = x;
            }
        }

        private IList<int> recursiveInorderTraversal(TreeNode root)
        {
            // InOrder Traversal requires doing a DFS on the left most node,

            // Base Case
            if (root == null)
            {
                return new List<int>();
            }

            IList<int> left = recursiveInorderTraversal(root.left);     // Recursively travel left
            left.Add(root.val);                                         // Once at the bottom, add the left node value
            IList<int> right = recursiveInorderTraversal(root.right);   // Recursively travel right

            // If a right node exists Add the right node's value to the list.
            if (right.Count > 0)
            {
                foreach (int nodeValue in right)
                {
                    left.Add(nodeValue);
                }
            }
            return left;
        }


        public override void PrintExample()
        {
            // TODO: Implement a method to create a BST when passed in an array
            throw new NotImplementedException();
        }
    }
}
