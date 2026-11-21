class Solution {
public:
    int longestConsecutive(vector<int>& nums)
    {
        unordered_set<int> Numbers;

        for(int Number : nums)
            Numbers.insert(Number);
        
        int Count = 0;
        int CurrentLength = 0;
        int MaxLength = 0;

        for(int Number : nums)
        {
            while(Numbers.count(Number + Count))
            {
                Count++;
                CurrentLength++;
            }

            MaxLength = max(MaxLength, CurrentLength);
            CurrentLength = 0;
            Count = 0;
        }

        return MaxLength;
    }
};