public class Solution
{
    public void Solve(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        // Mark all 'O's on the edge and connected to edge 'O's as non-capturable
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        Convert(board, i, j);
                    }
                }
            }
        }

        // Capture all remaining 'O's
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                {
                    board[i][j] = 'X';
                }
                else if (board[i][j] == 'Y')
                {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void Convert(char[][] board, int i, int j)
    {
        if (i >= 0 && i < board.Length && j >= 0 && j < board[0].Length && board[i][j] == 'O')
        {
            board[i][j] = 'Y';
            Convert(board, i - 1, j);
            Convert(board, i + 1, j);
            Convert(board, i, j - 1);
            Convert(board, i, j + 1);
        }
    }
}
