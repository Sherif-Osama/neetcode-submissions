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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if(list1 == null)
            return list2;
        if(list2 == null)
            return list1;

        ListNode CurrentNode1 = list1;
        ListNode NextNode1 = null;
        ListNode CurrentNode2 = list2;
        ListNode NextNode2 = null;
        ListNode Head = null;

        if(CurrentNode1.val > CurrentNode2.val)
            Head = CurrentNode2;
        else
            Head = CurrentNode1;

        ListNode Tail = Head;

        while(CurrentNode1 != null && CurrentNode2 != null)
        {
            NextNode1 = CurrentNode1.next;
            NextNode2 = CurrentNode2.next;

            if(CurrentNode1.val > CurrentNode2.val)
            {
                CurrentNode2.next = CurrentNode1;

                if(Tail != null)
                    Tail.next = CurrentNode2;

                Tail = CurrentNode2;
                CurrentNode2 = NextNode2;
            }
            else
            {
                CurrentNode1.next = CurrentNode2;
                
                if(Tail != null)
                    Tail.next = CurrentNode1;

                Tail = CurrentNode1;
                CurrentNode1 = NextNode1;
            }
        }

        if (CurrentNode1 != null)
             Tail.next = CurrentNode1;

        if(CurrentNode2 != null)
            Tail.next = CurrentNode2;

        return Head; 
    }
}