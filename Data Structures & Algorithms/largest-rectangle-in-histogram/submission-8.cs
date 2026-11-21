public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        var Columns = new Stack<KeyValuePair<int,int>>();
        int CurrentArrea = 0;
        int LargetArea = 0;
        int CurrentWidth = 0;
        int CurrentIndex = 0;

        Columns.Push(new KeyValuePair<int,int>(0,heights[0]));

        for(int i = 1; i < heights.Length; i++)
        {
            CurrentIndex = i;
            while(Columns.Count() != 0 && Columns.Peek().Value >heights[i])
            {
                var Column = Columns.Pop();
                CurrentWidth = Columns.Count() == 0 ? i : i - Column.Key;
                CurrentArrea = CurrentWidth * Column.Value;
                LargetArea = Math.Max(CurrentArrea, LargetArea);
                CurrentIndex = Column.Key;
            }

            Columns.Push(new KeyValuePair<int,int>(CurrentIndex, heights[i]));
        }

        while(Columns.Count() != 0)
        {
            var Column = Columns.Pop();
            CurrentWidth = Columns.Count() == 0 ? heights.Length : heights.Length - Column.Key;
            CurrentArrea = CurrentWidth * Column.Value;
            LargetArea = Math.Max(CurrentArrea, LargetArea);
        }

        return LargetArea;
    }
}
