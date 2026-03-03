using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
            return true;

        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;

        if (left == null || right == null)
            return false;

        if (left.val != right.val)
            return false;

        return IsMirror(left.left, right.right)
            && IsMirror(left.right, right.left);
    }
}

class Program
{
    static void Main()
    {
        TreeNode root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3),
                new TreeNode(4)),
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(3)));

        Solution sol = new Solution();

        Console.WriteLine(sol.IsSymmetric(root)); // True
    }
}