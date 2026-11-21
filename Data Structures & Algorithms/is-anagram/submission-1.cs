public class Solution 
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        int SharedLength = s.Length;

        int[] Frequency = new int[26];

        for(int i = 0; i < SharedLength; i++)
        {
            Frequency[s[i] - 'a']++;

            Frequency[t[i] - 'a']--;
        }

        foreach(var c in Frequency)
            if(c != 0)
                return false;

        return true;
    }
}
