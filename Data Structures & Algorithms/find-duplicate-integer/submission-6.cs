public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        int FastPointer = nums[nums[0]];
        int SlowPointer = nums[0];

        while(FastPointer != SlowPointer)
        {
            FastPointer = nums[nums[FastPointer]];
            SlowPointer = nums[SlowPointer];
        }

        SlowPointer = 0;

        while(FastPointer != SlowPointer)
        {
            FastPointer = nums[FastPointer];
            SlowPointer = nums[SlowPointer];
        }

        return FastPointer;
    }
}