public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null) return null;
        var cur = head;
        int count = 0;

        while (cur != null)
        {
            cur = cur.next;
            count++;
        }

        cur = head;

        for (int i = 0; i < count / 2 - 1; i++)
        {
            cur = cur.next;
        }

        cur.next = cur.next.next;

        return head;
    }
}