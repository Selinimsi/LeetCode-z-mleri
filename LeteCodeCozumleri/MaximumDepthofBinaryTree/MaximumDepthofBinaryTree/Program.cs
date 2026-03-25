using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
    {
        val = value;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Örnek ağaç oluşturuyoruz:
        //     3
        //    / \
        //   9  20
        //      / \
        //     15  7

        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Solution solution = new Solution();
        int depth = solution.MaxDepth(root);

        Console.WriteLine("Max Depth: " + depth);
    }
}