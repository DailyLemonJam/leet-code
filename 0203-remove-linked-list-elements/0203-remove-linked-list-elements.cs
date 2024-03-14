/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var temp = new ListNode(int.MaxValue, head);
        ListNode cur = head, prev = temp;

        while (cur != null)
        {
            if (cur.val == val)
            {
                prev.next = cur.next;
                cur = prev.next;
                continue;
            }
            prev = cur;
            cur = cur.next;
        }

        return temp.next;
    }
}