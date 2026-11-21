class Solution {
public:
    bool hasDuplicate(vector<int>& nums)
    {
            unordered_set<int> Numbers;

        for(int Number : nums)
        {
            if(Numbers.count(Number))
                return true;

                Numbers.insert(Number);
        }

        return false;
    }
};