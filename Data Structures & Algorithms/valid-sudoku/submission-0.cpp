class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board)
    {
        unordered_set<char> SetBox;
        unordered_set<char> SetRow;
        unordered_set<char> SetColumn;

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if(SetRow.count(board[i][j]))
                    return false;

                if(SetColumn.count(board[j][i]))
                    return false;
                
                if(board[i][j] != '.')
                SetRow.insert(board[i][j]);
                if(board[j][i] != '.')
                SetColumn.insert(board[j][i]);
            }
            SetRow.clear();
            SetColumn.clear();
        }

        for(int i = 0; i < 9; i++)
        {
            for(int Row = 0; Row < 3; Row++)
            {
                int StartRow =  (i / 3) * 3;

                for(int Colu = 0; Colu < 3; Colu++)
                {
                    int StartColum = (i % 3) * 3;
                    if(SetBox.count(board[Row + StartRow][Colu + StartColum]))
                        return false;
                    
                    if(board[Row + StartRow][Colu + StartColum] != '.')
                    SetBox.insert(board[Row + StartRow][Colu + StartColum]);
                }
            }
            SetBox.clear();;
        }

        return true;
    }
};
