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

        while(CurrentNode1 != null || CurrentNode2 != null || Remaining != 0)
        {
            Sum = Remaining;

            if(CurrentNode1 != null)
            Sum += CurrentNode1.val;

            if(CurrentNode2 != null)
             Sum += CurrentNode2.val;

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

            if(CurrentNode1 != null)
            CurrentNode1 = CurrentNode1.next;

            if(CurrentNode2 != null)
                CurrentNode2 = CurrentNode2.next;

            NewNode = NewNode.next;
        }
            
        return NewHead.next;   
    }
}