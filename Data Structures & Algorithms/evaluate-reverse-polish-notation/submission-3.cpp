class Solution {
   public:
    int evalRPN(vector<string>& tokens) {
        if (tokens.size() == 1) return stoi(tokens[0]);

        stack<int> operandsStack;
        int Right = 0;
        int Left = 0;

        for (string operands : tokens) {
            if (operands == "+") {
                Left = operandsStack.top();
                operandsStack.pop();
                Right = operandsStack.top();
                operandsStack.pop();
                operandsStack.push(Right + Left);
            } else if (operands == "-") {
                Left = operandsStack.top();
                operandsStack.pop();
                Right = operandsStack.top();
                operandsStack.pop();
                operandsStack.push(Right - Left);
            } else if (operands == "*") {
                Left = operandsStack.top();
                operandsStack.pop();
                Right = operandsStack.top();
                operandsStack.pop();
                operandsStack.push(Right * Left);
            } else if (operands == "/") {
                Left = operandsStack.top();
                operandsStack.pop();
                Right = operandsStack.top();
                operandsStack.pop();

                operandsStack.push(Right / Left);
            } else {
                operandsStack.push(stoi(operands));
            }
        }

        return operandsStack.top();
    }
};