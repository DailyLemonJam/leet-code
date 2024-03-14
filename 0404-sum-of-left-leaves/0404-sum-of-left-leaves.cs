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
    public int SumOfLeftLeaves(TreeNode root) {
        int sum = 0;

        void SumDfs(TreeNode node, bool isLeft)
        {
            if (node == null) return;

            if (node.left == node.right && isLeft)
            {
                sum += node.val;
            }
            
            SumDfs(node.left, true);
            SumDfs(node.right, false);
        }

        SumDfs(root, false);

        return sum;
    }
}