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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        if (list1 == null) {
            return list2;
        }
        if (list2 == null) {
            return list1;
        }
        ListNode head = new ListNode(val: -1);
        ListNode curr = head;


        while (list1 != null && list2 != null) {
            curr.next = new ListNode(Math.Min(list1.val, list2.val));
            if (list1.val < list2.val) {
                list1 = list1.next;
            }
            else {
                list2 = list2.next;
            }
            curr = curr.next;
        }

        while (list1 != null) {
            curr.next = new ListNode(val: list1.val);
            list1 = list1.next;
            curr = curr.next;
        }

        while (list2 != null) {
            curr.next = new ListNode(val: list2.val);
            list2 = list2.next;
            curr = curr.next;
        }

        return head.next;
    }
}