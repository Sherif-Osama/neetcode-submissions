public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> CountNumbers = new HashSet<int>();

        foreach(var num in nums)
        {
            if(CountNumbers.Contains(num))
                return true;

            CountNumbers.Add(num);
        }
        return false;
    }
}