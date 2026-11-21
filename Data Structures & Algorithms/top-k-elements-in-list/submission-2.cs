public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var Numbers = new Dictionary<int,int>();
        var Buckets = new List<List<int>>();
        var Result = new List<int>();

        foreach(var n in nums)
        {
            if(Numbers.ContainsKey(n))
                Numbers[n]++;
            else
                Numbers.Add(n, 1);
        }

        for(int i = 0; i < nums.Length + 1; i++)
            Buckets.Add(new List<int>());


        foreach(var n in Numbers)
        {
            Buckets[n.Value].Add(n.Key);
        }

        for(int i = Buckets.Count() - 1; i > 0; i--)
        {
            if(Buckets[i].Count() > 0)
            {
                foreach(var n in Buckets[i])
                {
                    Result.Add(n);
                }
            }

            if(Result.Count() == k)
                return Result.ToArray();
        }

        return Result.ToArray();
    }
}