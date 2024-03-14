public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        if (root == null) return new List<int>();
        var result = new List<int>() { root.val };

        var mainQ = new Queue<TreeNode>();
        var tempQ = new Queue<TreeNode>();
        mainQ.Enqueue(root);

        while (mainQ.Count > 0)
        {
            var node = mainQ.Dequeue();

            if (node.left != null) tempQ.Enqueue(node.left);
            if (node.right != null) tempQ.Enqueue(node.right);

            if (mainQ.Count == 0 && tempQ.Count > 0)
            {
                int lastNodeVal = int.MaxValue;
                while (tempQ.Count > 0)
                {
                    lastNodeVal = tempQ.Peek().val;
                    mainQ.Enqueue(tempQ.Dequeue());
                }
                result.Add(lastNodeVal);
            }
        }

        return result;
    }
}