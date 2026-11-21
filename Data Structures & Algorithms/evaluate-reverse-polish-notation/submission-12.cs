public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var Numbers = new Stack<int>();
        int result = 0;
        foreach(var token in tokens)
        {
            switch(token)
            {
                case "+":
                {
                    result = Numbers.Pop();
                    result += Numbers.Pop();
                    Numbers.Push(result);
                    break;
                }
                case "-":
                {
                    result = Numbers.Pop();
                    result = Numbers.Pop() - result;
                    Numbers.Push(result);
                    break;
                }
                case "*":
                {
                    result = Numbers.Pop();
                    result *= Numbers.Pop();
                    Numbers.Push(result);
                    break;
                }
                case "/":
                {
                    result = Numbers.Pop();
                    result = Numbers.Pop() / result;
                    Numbers.Push(result);
                    break;
                }
                default:
                    Numbers.Push(int.Parse(token));
                    break;
            }
        }
        return Numbers.Peek();
    }
}