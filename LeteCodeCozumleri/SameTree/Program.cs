public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);

        while (queue.Count > 0)
        {
            TreeNode node1 = queue.Dequeue();
            TreeNode node2 = queue.Dequeue();

            if (node1 == null && node2 == null)
                continue;

            if (node1 == null || node2 == null)
                return false;

            if (node1.val != node2.val)
                return false;

            queue.Enqueue(node1.left);
            queue.Enqueue(node2.left);
            queue.Enqueue(node1.right);
            queue.Enqueue(node2.right);
        }

        return true;
    }
}