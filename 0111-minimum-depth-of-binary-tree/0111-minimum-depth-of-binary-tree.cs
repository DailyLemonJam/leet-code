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
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        root.val = 1;
        var queue = new Queue<TreeNode>();
        TreeNode t;
        while (true)
        {
            if (root.left == root.right) return root.val;
            
            if (root.left != null)
            {
                t = root.left;
                t.val = root.val + 1;
                queue.Enqueue(t);
            }
            if (root.right != null)
            {
                t = root.right;
                t.val = root.val + 1;
                queue.Enqueue(t);
            }
            root = queue.Dequeue();
        }
    }
}