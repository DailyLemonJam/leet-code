public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var set = new HashSet<char>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] != '.' && !set.Add(board[i][j])) return false;
            }
            set.Clear();
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[j][i] != '.' && !set.Add(board[j][i])) return false;
            }
            set.Clear();
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int tempI = i * 3;
                int tempJ = j * 3;

                for (int x = tempI; x < tempI + 3; x++)
                {
                    for (int y = tempJ; y < tempJ + 3; y++)
                    {
                        if (board[x][y] != '.' && !set.Add(board[x][y])) return false;
                    }
                }
                
                set.Clear();
            }
        }

        return true;
    }
}