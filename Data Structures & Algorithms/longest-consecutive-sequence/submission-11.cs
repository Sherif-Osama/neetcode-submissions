public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var Sequence = new HashSet<int>();

        foreach(var n in nums)
            Sequence.Add(n);

        int CurrentLength = 0;
        int MaxLength = 0;

        foreach(var num in Sequence)
        {
            if(Sequence.Contains(num - 1))
                continue;
            
            while(Sequence.Contains(num + CurrentLength))
            {
                CurrentLength++;
            }
            MaxLength = Math.Max(MaxLength,CurrentLength );
            CurrentLength = 0;
        }

        return MaxLength;
    }
}
