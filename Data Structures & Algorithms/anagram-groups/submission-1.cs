public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
       if(strs.Length == 1)
        return new List<List<string>>{new List<string>{strs[0]}};

        int[] Frequency;
        var Groups = new Dictionary<string, List<string>>();
        string Key = string.Empty;
        foreach(var s in strs)
        {
            Frequency = new int[26];
            foreach(var c in s)
            {
                Frequency[c - 'a']++;
            }

            Key = string.Join(",", Frequency);

            if(Groups.ContainsKey(Key))
                Groups[Key].Add(s);
            else
                Groups.Add(Key,new List<string>(){s});


            Key = string.Empty;
        }
        
        var result = new List<List<string>>();
        foreach(var pair in Groups)
        {
            result.Add(pair.Value);
        }

        return result;
    }
}
