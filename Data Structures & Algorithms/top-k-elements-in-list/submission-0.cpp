class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) 
    {
        unordered_map<int,int> Freq;

        for(int Number : nums)
            Freq[Number]++;
        
        vector<vector<int>> Buckt(nums.size() + 1);

        for(auto& Pairs : Freq)
            Buckt[Pairs.second].push_back(Pairs.first);

        vector<int> Answer;

        for(int i = nums.size(); i >= 0; i--)
        {
            if(Buckt[i].size() == 0)
                continue;
            
            for(int Number : Buckt[i])
            {

             Answer.push_back(Number);
             if(Answer.size() ==  k)
                return Answer;
            }
        }

        return Answer;
    }
};
