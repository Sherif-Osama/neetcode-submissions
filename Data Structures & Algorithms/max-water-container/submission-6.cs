public class Solution
{
    public int MaxArea(int[] heights) 
    {
        int Left = 0; 
        int Right = heights.Length - 1;
        int MaxArea = 0;
        int minColumn = 0;
        int CurrentArea = 0;

        while(Left < Right)
        {
            minColumn = Math.Min(heights[Left], heights[Right]);
            CurrentArea = minColumn * (Right - Left);
            MaxArea = Math.Max(MaxArea, CurrentArea);

            if(heights[Left] > heights[Right])
                Right--;
            else if(heights[Left] < heights[Right])
                Left++;
            else if(heights[Left] == heights[Right])
            {
                CurrentArea =  heights[Right] * (Right - Left);
                MaxArea = Math.Max(MaxArea, CurrentArea);
                Left++;
                Right--;
            }
        }

        return MaxArea;
    }
}