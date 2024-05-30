
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

//SolveSudoku(board1);
SolveSudoku(board2);


Console.ReadLine();


HashSet<char>[] rowValues;
HashSet<char>[] colValues;
HashSet<char>[] boxValues;

void SolveSudoku(char[][] board)
{
    rowValues = new HashSet<char>[9];
    colValues = new HashSet<char>[9];
    boxValues = new HashSet<char>[9];

    for (int i = 0; i < 9; i++)
    {
        rowValues[i] = new HashSet<char>();
        colValues[i] = new HashSet<char>();
        boxValues[i] = new HashSet<char>();
    }

    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            char cell = board[row][col];

            if (cell == '.') continue;

            int boxIndex = ((row / 3) * 3) + (col / 3);

            rowValues[row].Add(cell);
            colValues[col].Add(cell);
            boxValues[boxIndex].Add(cell);
        }
    }

    Solve(board, 0, 0);

}

bool Solve(char[][] board, int row, int col)
{
    if (row >= 9 || row == 8 && col > 8) return true;

    char cell = board[row][col];
    while (cell != '.')
    {
        col++;
        if (col == 9)
        {
            row++;
            col = 0;
        }
        if (row >= 9 || row == 8 && col > 8) return true;

        cell = board[row][col];
    }

    int boxIndex = ((row / 3) * 3) + (col / 3);

    bool isValid = false;

    for (int num = 1; num <= 9; num++)
    {
        char cNum = Convert.ToChar(num + 48);

        if (rowValues[row].Contains(cNum)
        || colValues[col].Contains(cNum)
        || boxValues[boxIndex].Contains(cNum)
        )
        {
            continue;
        }

        board[row][col] = cNum;
        rowValues[row].Add(cNum);
        colValues[col].Add(cNum);
        boxValues[boxIndex].Add(cNum);

        isValid = Solve(board, row, col);

        if (isValid)
        {
            return isValid;
        }
        else
        {
            board[row][col] = '.';
            rowValues[row].Remove(cNum);
            colValues[col].Remove(cNum);
            boxValues[boxIndex].Remove(cNum);
        }
    }

    return isValid;
}