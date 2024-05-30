
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

Print(board2);
SolveSudoku(board2);

Print(board2);
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
    if (row == 9 || row == 8 && col == 8)
    {
        return true;
    }

    char item = board[row][col];

    while (item != '.')
    {
        col++;
        if (col == 9)
        {
            row++;
            col = 0;
        }

        if (row == 9 || row == 8 && col > 8)
        {
            return true;
        }
        item = board[row][col];
    }

    bool isValid = false;
    int chunk = ((row / 3) * 3) + (col / 3);

    for (int i = 1; i <= 9; i++)
    {
        char currentItem = Convert.ToChar(i + 48);

       

        if (rows[row].Contains(currentItem) || cols[col].Contains(currentItem) || chunks[chunk].Contains(currentItem))
        {
            continue;
        }

        board[row][col] = currentItem;
        rows[row].Add(currentItem);
        cols[col].Add(currentItem);
        chunks[chunk].Add(currentItem);

        isValid = Selection(board, row, col);

        if (isValid)
        {
            return true;
        }
        else
        {
            board[row][col] = '.';
            rows[row].Remove(currentItem);
            cols[col].Remove(currentItem);
            chunks[chunk].Remove(currentItem);
        }

    }


    return isValid;
}

static void Print(char[][] array)
{
    Console.WriteLine();
    for (int row = 0; row < array.Length; row++)
    {
        for (int col = 0; col < array[row].Length; col++)
        {
            if (array[row][col] == '-') { Console.ForegroundColor = ConsoleColor.Red; }
            Console.Write("{0}", array[row][col] + " ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}