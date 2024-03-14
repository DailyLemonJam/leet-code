public class Solution
{
    public int PairSum(ListNode head)
    {
        var allValues = new List<int>();

        var cur = head;
        while (cur != null)
        {
            allValues.Add(cur.val);
            cur = cur.next;
        }

        int max = int.MinValue;
        for (int i = 0; i < allValues.Count / 2; i++)
        {
            int pairSum = allValues[i] + allValues[allValues.Count - 1 - i];
            if (pairSum > max) max = pairSum;
        }

        return max;
    }
}