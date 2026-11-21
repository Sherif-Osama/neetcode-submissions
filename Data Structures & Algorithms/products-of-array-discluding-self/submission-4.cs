public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int Length = nums.Length;
        var output = new int[Length];
        int Sum = 1;

        for(int i = 0; i < Length; i++)
        {
            output[i] = Sum;
            Sum = output[i] * nums[i];
        }

        Sum = 1;
        for(int i = Length - 1; i >= 0; i--)
        {
            output[i] *= Sum;
            Sum *= nums[i];
        }

        return output;
    }
}