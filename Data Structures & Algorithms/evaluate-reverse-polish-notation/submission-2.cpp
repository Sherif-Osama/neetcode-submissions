class Solution {
public:
    int evalRPN(vector<string>& tokens)
    {
        if(tokens.size() == 1)
            return stoi(tokens[0]);
            
        stack<string> operandsStack;
        int Right = 0;
        int Left = 0;
        string Result = "";

        for(string operands : tokens)
        {
            if(operands == "+")
            {
                Left = stoi(operandsStack.top());
                    operandsStack.pop();
                Right = stoi(operandsStack.top());
                    operandsStack.pop();

                Result = to_string(Right + Left);

                operandsStack.push(Result); 
            }
            else if(operands == "-")
            {
                Left = stoi(operandsStack.top());
                    operandsStack.pop();
                Right = stoi(operandsStack.top());
                    operandsStack.pop();

                Result = to_string(Right - Left);

                operandsStack.push(Result); 
            }
            else if(operands == "*")
            {
                Left = stoi(operandsStack.top());
                    operandsStack.pop();
                Right = stoi(operandsStack.top());
                    operandsStack.pop();

                Result = to_string(Right * Left);

                operandsStack.push(Result); 
            }
            else if(operands == "/")
            {
                Left = stoi(operandsStack.top());
                    operandsStack.pop();
                Right = stoi(operandsStack.top());
                    operandsStack.pop();

                Result = to_string(Right / Left);

                operandsStack.push(Result); 
            }
            else
            {
                operandsStack.push(operands);
            }
        }

        return stoi(Result);
    }
};
