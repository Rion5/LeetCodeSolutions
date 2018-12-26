using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib
{
    /// <summary>
    /// 104. Maximum Depth of Binary Tree
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// IE) Input:  [3,9,20,null,null,15,7]
    ///     Output: 3
    /// </summary>
    ///      3
    ///     / \
    ///    9  20
    ///      /  \
    ///     15   7
    public class MaximumDepthOfBinaryTree: Solution
    {
        // Definition for a binary tree node
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val)
            {
                this.val = val;
            }
        }

        private int maximumDepth(TreeNode root)
        {
            // Recursion with DFS
            // Time Complexity : O(n) where n is the # of nodes
            // Space Complexity: O(log n)

            if (root == null)
            {
                return 0;
            }

            // Recursive function to get the height of left and right node
            int left = maximumDepth(root.left);
            int right = maximumDepth(root.right);

            return Math.Max(left, right) + 1;
        }
        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //var results = maximumDepth();
            watch.Stop();
            Console.WriteLine($"104. Maximum Depth of Binary Tree\n" +
                              $"Binary Tree =  \n" +
                             // $"Result: [{results}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
