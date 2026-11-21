public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var Sequence = new HashSet<int>();

        foreach(var n in nums)
            Sequence.Add(n);

        int CurrentLength = 0;
        int MaxLength = 0;

        foreach(var n in nums)
        {
            while(Sequence.Contains(n + CurrentLength) && !Sequence.Contains(n - 1))
            {
                CurrentLength++;
            }

            MaxLength = Math.Max(MaxLength, CurrentLength);
            CurrentLength = 0;
        }

        return MaxLength;
    }
}
