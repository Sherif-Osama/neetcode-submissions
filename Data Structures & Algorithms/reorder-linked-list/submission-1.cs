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
    public void ReorderList(ListNode head) 
    {
        if(head == null || head.next == null)
            return;

        ListNode PreviousNode = head;
        ListNode FastPointer = head;
        ListNode SlowPointer = head;
        ListNode NextNode = null;
        ListNode CurrentNode = head;
        ListNode PreviousNodeInReversedList = null;
        ListNode NextNodeInReversedList = null;

        while(FastPointer != null && FastPointer.next != null)
        {
            PreviousNode = SlowPointer;
            SlowPointer = SlowPointer.next;
            FastPointer = FastPointer.next.next;
        }

        PreviousNode.next = null;

        while(SlowPointer != null)
        {
            NextNode = SlowPointer.next;
            SlowPointer.next = PreviousNodeInReversedList;
            PreviousNodeInReversedList = SlowPointer;
            SlowPointer = NextNode;
        }

        while(CurrentNode != null)
        {
            NextNode = CurrentNode.next;
            NextNodeInReversedList = PreviousNodeInReversedList.next;
            PreviousNodeInReversedList.next = NextNode;
            CurrentNode.next = PreviousNodeInReversedList;
            PreviousNode = CurrentNode;
            CurrentNode = NextNode;
            PreviousNodeInReversedList = NextNodeInReversedList;
        }

        if(PreviousNodeInReversedList != null)
            PreviousNode.next.next = PreviousNodeInReversedList;
    }
}
