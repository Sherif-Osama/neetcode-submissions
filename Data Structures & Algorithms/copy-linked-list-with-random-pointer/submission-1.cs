/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution 
{
    public Node copyRandomList(Node head) 
    {
        if(head == null)
            return head;
            
        Node CurrentNode = head;
        var NodeSet = new Dictionary<Node,Node>();

        while(CurrentNode != null)
        {
            NodeSet.Add(CurrentNode, new Node(CurrentNode.val));
            CurrentNode = CurrentNode.next;
        }

        CurrentNode = head;

        var NewHead = NodeSet[CurrentNode];

        while(CurrentNode != null)
        {
            if(CurrentNode.next != null)
                NodeSet[CurrentNode].next = NodeSet[CurrentNode.next];
            else 
                 NodeSet[CurrentNode].next = null;

            if(CurrentNode.random != null)
                NodeSet[CurrentNode].random = NodeSet[CurrentNode.random];
            else
                NodeSet[CurrentNode].random = null;

            CurrentNode = CurrentNode.next;
        }

        return NewHead;
    }
}

