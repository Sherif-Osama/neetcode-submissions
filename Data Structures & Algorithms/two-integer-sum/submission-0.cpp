class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        unordered_map<int,int> Sum;
        int Result = 0;

        for(int i = 0; i < nums.size(); i++)
        {
            Result = target - nums[i];

            if(Sum.count(Result))
                return {Sum[Result], i};
            
            Sum[nums[i]] = i;
        }   
    }
};
