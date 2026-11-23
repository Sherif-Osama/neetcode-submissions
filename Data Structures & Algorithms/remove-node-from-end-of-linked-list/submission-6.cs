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
        if(head == null || head.next == null)
            return null;

        ListNode FrontPointer = head;
        ListNode BackPointer = head;
        ListNode PreviousNode = head;

        for(int i = 0; i < n; i++)
            FrontPointer = FrontPointer.next;


        if(FrontPointer == null)
        {
            head = head.next;

            return head;
        }

        while(FrontPointer != null)
        {
            FrontPointer = FrontPointer.next;
            PreviousNode = BackPointer;
            BackPointer = BackPointer.next;
        }

        PreviousNode.next = BackPointer.next;

        return head;
    }
}