public class MinStack {

    public MinStack() {
        stack = new Stack<KeyValuePair<int,int>>();
    }

    Stack<KeyValuePair<int,int>> stack;

    int min = 0;

    public void Push(int val)
    {
        if(stack.Count() == 0 || val < min)
            min = val;

        stack.Push(new KeyValuePair<int,int>(val, min));
    }
    
    public void Pop() 
    {
        stack.Pop();
    if(stack.Count() != 0)
        min = stack.Peek().Value;   
    }
    
    public int Top() {
     return stack.Peek().Key;   
    }
    
    public int GetMin() {
        return min;
    }
}