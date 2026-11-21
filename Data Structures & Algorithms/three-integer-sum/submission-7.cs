public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        int Sum = 0;
        int Left = 0;
        int Right = nums.Length - 1;
        var result = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1])
                continue;

            Left = i + 1;
            Right = nums.Length - 1;
            while(Left < Right)
            {
                Sum = nums[Left] + nums[Right] + nums[i];

                if(Sum > 0)
                    Right--;
                else if(Sum < 0)
                    Left++;
                else if(Sum == 0)
                {
                    result.Add(new List<int>(){nums[Left],nums[Right] ,nums[i]});
                    Left++;
                    Right--;

                while(Left < Right && nums[Left - 1] == nums[Left])
                    Left++;

                while(Right > Left && nums[Right + 1] == nums[Right])
                    Right--;  
                }
            }
        }
        
        return result;
    }
}