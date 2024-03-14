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
    public ListNode MiddleNode(ListNode head) {
        ListNode midNode = head;
        ListNode endNode = head;
        while (endNode != null && endNode.next != null)
        {
            midNode = midNode.next;
            endNode = endNode.next.next;
        }
        return midNode;
    }
}