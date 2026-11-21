public class Solution {
    public bool IsValid(string s) 
    {
         var Parentheses = new Stack<char>();

         foreach(var c in s)
         {
            if(Parentheses.Count() <= 0)
            {
                Parentheses.Push(c);
                continue;
            }

            if( c == '}' && Parentheses.Peek() == '{')
            {
                Parentheses.Pop();
            }
            else if(c == ')' && Parentheses.Peek() == '(')
            {
                Parentheses.Pop();
            }
            else if(c == ']' && Parentheses.Peek() == '[')
                Parentheses.Pop();
            else
            Parentheses.Push(c);
         }
         return (Parentheses.Count() <= 0);
    }
}