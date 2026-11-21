class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures)
    {
        stack<int> Indices;
        vector<int> Result(temperatures.size(), 0);

        for(int i = 0;  i <= temperatures.size() - 1; i++)
        {
            while(!Indices.empty() && temperatures[Indices.top()] < temperatures[i])
            {
                Result[Indices.top()] =  i - Indices.top();

                Indices.pop();
            }

            Indices.push(i);
        }

        return Result;
    }
};