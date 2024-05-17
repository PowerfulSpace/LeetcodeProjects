
char[][] board1 = {
    new char[]{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
    new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
    new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
    new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
    new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
    new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
    new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
    new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
    new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};


char[][] board2 = {
    new char[]{'8','3','.','.','7','.','.','.','.'},
    new char[]{'6','.','.','1','9','5','.','.','.'},
    new char[]{'.','9','8','.','.','.','.','6','.'},
    new char[]{'8','.','.','.','6','.','.','.','3'},
    new char[]{'4','.','.','8','.','3','.','.','1'},
    new char[]{'7','.','.','.','2','.','.','.','6'},
    new char[]{'.','6','.','.','.','.','2','8','.'},
    new char[]{'.','.','.','4','1','9','.','.','5'},
    new char[]{'.','.','.','.','8','.','.','7','9'} };




Console.WriteLine(IsValidSudoku(board1));
Console.WriteLine(IsValidSudoku(board2));


Console.ReadLine();

static bool IsValidSudoku(char[][] board)
{

    int length = 9;
    int x = 0;
    int y = 0;

    for (int i = 0; i < length; i++)
    {
        char num = board[i][i]; 
        for (x = 0; x < length; x++)
        {
            if(num == board[0][x] && board[0][x] != board[i][i])
            {
                return false;
            }
        }
        for (y = 0; y < length; y++)
        {
            if (num == board[y][0] && board[0][y] != board[i][i])
            {
                return false;
            }
        }
    }

    return true;
}