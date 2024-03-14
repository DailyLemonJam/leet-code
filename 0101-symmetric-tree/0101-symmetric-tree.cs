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
public class Solution {
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        if (root.left == root.right) return true;
        if (root.left == null || root.right == null) return false;
        
        var leftQueue = new Queue<TreeNode>();
        var rightQueue = new Queue<TreeNode>();
        leftQueue.Enqueue(root.left);
        rightQueue.Enqueue(root.right);

        TreeNode r;
        TreeNode l;
        
        while (leftQueue.Count != 0)
        {
            l = leftQueue.Dequeue();
            r = rightQueue.Dequeue();
            if (l.val != r.val) return false;

            if (l.left != null && r.right != null)
            {
                leftQueue.Enqueue(l.left);
                rightQueue.Enqueue(r.right);
            }
            else if (l.left != r.right) return false;

            if (l.right != null && r.left != null)
            {
                leftQueue.Enqueue(l.right);
                rightQueue.Enqueue(r.left);
            }
            else if (l.right != r.left) return false;
        }
        return true;
    }
}