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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var temp = new ListNode(-1) { next = head };
        var right = head;
        var left = temp;

        while (n > 0 && right != null)
        {
            right = right.next;
            n--;
        }

        while (right != null)
        {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;

        return temp.next;
    }
}