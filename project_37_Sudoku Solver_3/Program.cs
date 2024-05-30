
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
 new char[]{'.','.','9','7','4','8','.','.','.'},
 new char[]{'7','.','.','.','.','.','.','.','.'},
 new char[]{'.','2','.','1','.','9','.','.','.'},
 new char[]{'.','.','7','.','.','.','2','4','.'},
 new char[]{'.','6','4','.','1','.','5','9','.'},
 new char[]{'.','9','8','.','.','.','3','.','.'},
 new char[]{'.','.','.','8','.','3','.','2','.'},
 new char[]{'.','.','.','.','.','.','.','.','6'},
 new char[]{'.','.','.','2','7','5','9','.','.'}};

SolveSudoku(board2);


Console.ReadLine();

HashSet<char>[] rows;
HashSet<char>[] cols;
HashSet<char>[] chunks;

void SolveSudoku(char[][] board)
{
    rows = new HashSet<char>[board.Length];
    cols = new HashSet<char>[board.Length];
    chunks = new HashSet<char>[board.Length];

    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            rows[col] = new HashSet<char>();
            cols[col] = new HashSet<char>();
            chunks[col] = new HashSet<char>();
        }
    }

    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            char item = board[row][col];
            if(item == '.') { continue; }

            int chunck = ((row / 3) * 3) + (col / 3);

            rows[row].Add(item);
            cols[col].Add(item);
            chunks[chunck].Add(item);

        }
    }

    Selection(board, 0, 0);
}



bool Selection(char[][] board, int row, int col)
{




}