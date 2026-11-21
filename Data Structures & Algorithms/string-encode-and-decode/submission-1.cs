public class Solution 
{
    char Separator = '#';

    public string Encode(IList<string> strs) 
    {
        string result = string.Empty;

        foreach(var s in strs)
            result += s.Length.ToString() + Separator + s; 

        return result;
    }

    public List<string> Decode(string s)
    {
        var listResult = new List<string>();
        var st = string.Empty;
        int Length = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != Separator)
            {
                st += s[i];
                continue;
            }

            Length = int.Parse(st);
            listResult.Add(s.Substring(i + 1, Length));
            i += Length;
            st = string.Empty;
        }

        return listResult;
    }
}
