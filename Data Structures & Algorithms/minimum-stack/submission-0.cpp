class MinStack {
public:
    MinStack() {}

    stack<pair<int, int>> MainStack;

    void push(int val)
    {
        if (MainStack.empty() || getMin() > val)
        {
            MainStack.push(pair<int, int>(val, val));
            return;
        }
        else
        {
            MainStack.push(pair<int, int>(val, getMin()));
        }
    }

    void pop()
    {
        MainStack.pop();
    }

    int top()
    {
        return MainStack.top().first;
    }

    int getMin()
    {
        return MainStack.top().second;
    }
};