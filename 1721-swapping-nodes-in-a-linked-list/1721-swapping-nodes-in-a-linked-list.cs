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
public class Solution {
    public ListNode SwapNodes(ListNode head, int k) {
        if (head == null) return head;
        
        ListNode cur = head;

        while (k != 1)
        {
            cur = cur.next;
            k--;
        }

        ListNode left = cur;
        ListNode right = head;

        while (cur.next != null)
        {
            cur = cur.next;
            right = right.next;
        }

        (left.val, right.val) = (right.val, left.val);
        return head;
    }
}