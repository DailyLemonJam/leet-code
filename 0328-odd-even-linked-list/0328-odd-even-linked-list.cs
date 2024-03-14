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
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null) return null;

        var oddEnd = head;
        var evenEnd = head.next;
        var evenHead = evenEnd;

        while (evenEnd != null && evenEnd.next != null)
        {
            oddEnd.next = evenEnd.next;
            oddEnd = oddEnd.next;
            evenEnd.next = oddEnd.next;
            evenEnd = evenEnd.next;
        }

        oddEnd.next = evenHead;

        return head;
    }
}