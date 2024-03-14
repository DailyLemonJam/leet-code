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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        
        if (root == null) return result;
        
        var stack = new Stack<TreeNode>();
        var resStack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            resStack.Push(node);

            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }

        while (resStack.Count > 0)
        {
            result.Add(resStack.Pop().val);
        }

        return result;
    }
}