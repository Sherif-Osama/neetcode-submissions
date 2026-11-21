class Solution 
{
   public:
    bool isValid(string s) 
    {
        stack<char> st;
        for (char c : s)
        {
            if (st.empty()){
                st.push(c);
                continue;
            }

            if (c == ']') 
            {
                
            if (st.top() == '[') 
                st.pop();
            else 
                 return false;
            }
            else if (c == '}')
            {
                if (st.top() == '{')
                 st.pop();
                 else 
                 return false;
            }
            else if (c == ')')
            {
            if (st.top() == '(')
                 st.pop();
                 else 
                 return false;
            }

        if(c != ']' && c != '}'&& c != ')')
            st.push(c);
        }

        return st.empty();
    }
};