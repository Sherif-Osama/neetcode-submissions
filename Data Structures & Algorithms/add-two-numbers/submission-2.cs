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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode CurrentNode1 = l1;
        ListNode CurrentNode2 = l2;
        int Sum = 0;
        int Remaining = 0;
        ListNode NewHead = new ListNode(0);
        ListNode NewNode = NewHead;

        while(CurrentNode1 != null && CurrentNode2 != null)
        {
            Sum = CurrentNode1.val + CurrentNode2.val + Remaining;

            if(Sum >= 10)
            {
                NewNode.next = new ListNode(Sum % 10);
                Remaining = 1;
            }
            else
            {
                NewNode.next = new ListNode(Sum);
                Remaining = 0;
            }

            CurrentNode1 = CurrentNode1.next;
            CurrentNode2 = CurrentNode2.next;
            NewNode = NewNode.next;
        }

        while(CurrentNode1 != null)
        {
            Sum = CurrentNode1.val + Remaining;

            if(Sum >= 10)
            {
                NewNode.next = new ListNode(Sum % 10);
                Remaining = 1;
            }
            else
            {
                NewNode.next = new ListNode(Sum);
                Remaining = 0;
            }

            CurrentNode1 = CurrentNode1.next;
            NewNode = NewNode.next;
        }

        while(CurrentNode2 != null)
        {
            Sum = CurrentNode2.val + Remaining;

            if(Sum >= 10)
            {
                NewNode.next = new ListNode(Sum % 10);
                Remaining = 1;
            }
            else
            {
                NewNode.next = new ListNode(Sum);
                Remaining = 0;
            }

            CurrentNode2 = CurrentNode2.next;
            NewNode = NewNode.next;
        }

        if(Remaining != 0)
            NewNode.next = new ListNode(Remaining);
            
        return NewHead.next;   
    }
}