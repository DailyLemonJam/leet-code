public class Solution
{
    public int MaxLevelSum(TreeNode root)
    {
        int maxLevel = 1;
        int maxLevelSum = root.val;
        int currentLevel = maxLevel;
        int currentLevelSum = 0;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var tempQ = new Queue<TreeNode>();

        while (q.Count > 0)
        {
            var node = q.Dequeue();

            if (node.left != null) tempQ.Enqueue(node.left);
            if (node.right != null) tempQ.Enqueue(node.right);

            if (q.Count == 0 && tempQ.Count > 0)
            {
                currentLevel++;
                while (tempQ.Count > 0)
                {
                    currentLevelSum += tempQ.Peek().val;
                    q.Enqueue(tempQ.Dequeue());
                }
                
                if (currentLevelSum > maxLevelSum)
                {
                    maxLevelSum = currentLevelSum;
                    maxLevel = currentLevel;
                }
            }
            currentLevelSum = 0;
        }

        return maxLevel;
    }
}