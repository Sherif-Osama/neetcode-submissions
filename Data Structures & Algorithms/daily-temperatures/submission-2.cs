public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var days = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(days.Count() != 0 && temperatures[i] > temperatures[days.Peek()])
            {
                    result[days.Peek()] = i -  days.Pop();
            }

            days.Push(i);
        }

        return result;
    }
}