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
    public string Tree2str(TreeNode root) {
        if (root == null) return "";

        var res = new StringBuilder();
        res.Append(root.val);

        if (root.left != null || root.right != null)
        {
            res.Append("(" + Tree2str(root.left) + ")");
        }
        if (root.right != null)
        {
            res.Append("(" + Tree2str(root.right) + ")");
        }

        return res.ToString();
    }
}