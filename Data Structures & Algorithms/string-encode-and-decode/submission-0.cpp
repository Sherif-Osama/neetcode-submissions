class Solution {
   public:
    string encode(vector<string>& strs) {

        string Result = "";
        for (string& s : strs) 
        Result += to_string(s.length()) + "!" + s;

        return Result;
    }

    vector<string> decode(string s)
    {
        vector<string> Answer;
        int Length = 0;
        string LengthString = "";
        for(int i = 0; i < s.length(); i++)
        {
            if(s[i] != '!')
            {
                LengthString += s[i];
                continue;
            }

            Length = stoi(LengthString);
            Answer.push_back(s.substr(i + 1, Length));

            LengthString = "";
            i += Length;
        }

        return Answer;
    }
};
