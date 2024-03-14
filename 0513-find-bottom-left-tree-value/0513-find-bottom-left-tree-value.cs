/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int last = root.val;

        while (q.Count > 0)
        {
            TreeNode node = q.Dequeue();
            last = node.val;
            if (node.right != null) q.Enqueue(node.right);
            if (node.left != null) q.Enqueue(node.left);
        }

        return last;
    }
}