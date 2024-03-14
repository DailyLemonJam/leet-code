public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode();
        var cur = result;

        int saved = 0;
        while (true)
        {
            if (l1 != null)
            {
                cur.val += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                cur.val += l2.val;
                l2 = l2.next;
            }
            
            cur.val += saved;
            saved = 0;
            if (cur.val >= 10)
            {
                cur.val -= 10;
                saved = 1;
            }

            if (l1 == l2) break;

            cur.next = new ListNode();
            cur = cur.next;
        }

        if (saved == 1) cur.next = new ListNode(saved);

        return result;
    }
}