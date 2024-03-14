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
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        int result = 0;

        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);

            if (node.val >= low && node.val <= high) result += node.val;
        }

        return result;
    }
}