
/**
 * https://leetcode.com/problems/reverse-linked-list/submissions/
 * Reverse a linked list
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
    public ListNode ReverseList(ListNode head) {
        if (head == null) return head;
        if (head.next == null) return head;
        ListNode previous = null;
        ListNode current = head;
        ListNode next = current.next;
        while (current != null){
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
            
        }
        return previous;
    }
}
