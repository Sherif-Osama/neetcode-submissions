class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) 
    {
        unordered_map<string,vector<string>> Anagrams;
        string Value = "";
        for(string s : strs)
        {
            Value = s;
            sort(s.begin(), s.end());

            Anagrams[s].push_back(Value);
        }

        vector<vector<string>> Answer;

        for(auto& Pairs: Anagrams)
            Answer.push_back(Pairs.second);
        

        return Answer;
    }
};
