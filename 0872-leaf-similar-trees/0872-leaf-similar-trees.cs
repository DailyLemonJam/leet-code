public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var q = new Queue<int>();

        var stack = new Stack<TreeNode>();
        stack.Push(root1);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            if (node.left == node.right) q.Enqueue(node.val);

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }

        stack.Push(root2);

        while (stack.Count > 0)
        {
            var node = stack.Pop();

            if (node.left == node.right)
            {
                if (q.Count == 0) return false;
                if (node.val != q.Dequeue()) return false;
            }
            
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }

        if (q.Count > 0) return false;

        return true;
    }
}