public class Solution
{
    public int Trap(int[] height)
    {
        int MaxLeft = 0;
        int MaxRight = 0;
        int LeftPointer = 0;
        int RightPointer = height.Length - 1;
        int TrappedAmount = 0;

        while(LeftPointer <= RightPointer)
        {
            MaxLeft = Math.Max(MaxLeft, height[LeftPointer]);
            MaxRight = Math.Max(MaxRight, height[RightPointer]);

            if(MaxLeft < MaxRight)
            {
                TrappedAmount += MaxLeft - height[LeftPointer];
                LeftPointer++;
            }
            else
            {
                TrappedAmount += MaxRight - height[RightPointer];
                RightPointer--;
            }
        }

        return TrappedAmount;  
    }
}
