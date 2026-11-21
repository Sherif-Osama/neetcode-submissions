public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        int Left = 0;
        int Right = numbers.Length - 1;
        int Sum = 0;
        while(Left < Right)
        {
            Sum = numbers[Left] + numbers[Right];

            if(Sum > target)
                Right --;
            
            if(Sum < target)
                Left++;
            
            if(Sum == target)
                return new int[] {Left+1, Right+1};
        }

        return new int[] {};
    }
}
