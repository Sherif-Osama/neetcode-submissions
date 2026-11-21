public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        var Values = new Dictionary<int, int>();
        int CurrentNumber = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            CurrentNumber = target - nums[i];

            if(Values.ContainsKey(CurrentNumber))
                return new int[] {Values[CurrentNumber], i};

            Values[nums[i]] = i;
        }
        return new int [] {};
    }
}