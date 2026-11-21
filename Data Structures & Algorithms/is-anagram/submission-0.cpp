class Solution {
public:
    bool isAnagram(string s, string t) 
    {
        if(s.length() != t.length())
            return false;

        unordered_map<char,int> Freq;

        for(char c : s)
            Freq[c]++;

        for(char c : t)
        {
            if(!Freq.count(c) || Freq[c] == 0)
                return false;

            Freq[c]--;
        }

        return true;
    }
};
