public class Solution {
    public void Solve(char[][] board) {
        for (int i = 0; i < board[0].Length; i++) {
            FlagDFS(board, 0, i);
            FlagDFS(board, board.Length - 1, i);
        }
        for (int i = 0; i < board.Length; i++) {
            FlagDFS(board, i, 0);
            FlagDFS(board, i, board[0].Length - 1);
        }

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (board[i][j] == '#') {
                    board[i][j] = 'O';
                }
                else if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                }
            }
        }
    }

    public void FlagDFS(char[][] board, int x, int y) {
        if (x < 0 || y < 0 || x > board.Length - 1 || y > board[x].Length - 1) {
            return;
        }

        if (board[x][y] == 'X' || board[x][y] == '#') {
            return;
        }

        if (board[x][y] == 'O') {
            board[x][y] = '#';
        }

        FlagDFS(board, x - 1, y);
        FlagDFS(board, x + 1, y);
        FlagDFS(board, x, y - 1);
        FlagDFS(board, x, y + 1);
    }
}
