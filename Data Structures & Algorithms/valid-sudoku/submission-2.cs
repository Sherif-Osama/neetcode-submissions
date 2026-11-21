public class Solution 
{
    public bool IsValidSudoku(char[][] board)
    {
        var Rows = new HashSet<char>();
        var Columns = new HashSet<char>();
        var SetBox = new HashSet<char>();

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if(Rows.Contains(board[i][j]) || Columns.Contains(board[j][i]))
                    return false;
                
                if(board[i][j] != '.')
                Rows.Add(board[i][j]);

                if(board[j][i] != '.')
                Columns.Add(board[j][i]);
            }
            Rows.Clear();
            Columns.Clear();
        }

        int StartRow = 0;

        for(int i = 0; i < 9; i++)
        {
            for(int Row = 0; Row < 3; Row++)
            {
                StartRow = (i/3) * 3;

                for(int Column = 0; Column < 3;Column++)
                {
                    int StartColum = (i % 3) * 3;

                    if(SetBox.Contains(board[Row + StartRow][Column + StartColum]))
                        return false;

                    if(board[Row + StartRow][Column + StartColum] != '.')
                        SetBox.Add(board[Row + StartRow][Column + StartColum]);
                }
            }
                SetBox.Clear();
        }

        return true;
    }
}
