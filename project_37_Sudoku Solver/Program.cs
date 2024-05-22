
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

SolveSudoku(board1);
SolveSudoku(board2);


Console.ReadLine();

static void SolveSudoku(char[][] board)
{
    List<char>[] rows = new List<char>[9];
    List<char>[] cols = new List<char>[9];
    List<char>[] chancks = new List<char>[9];

    bool isValid = IsValidSudoku(board, rows, cols, chancks);
    if(!isValid) { return; }


    char[,] array = FillingArray(rows);

    List<char> priorityCheck = ScanPriorityCheck(rows);

    FillingTheVoid(priorityCheck,rows,cols,chancks);

    Console.WriteLine();
}

static bool IsValidSudoku(char[][] board, List<char>[] rows, List<char>[] cols, List<char>[] chancks)
{
    for (int i = 0; i < 9; i++)
    {
        rows[i] = new List<char>();
        cols[i] = new List<char>();
        chancks[i] = new List<char>();
    }

    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            char item = board[row][col];

            int chanck = ((row / 3) * 3) + (col / 3);
            if (item != '.')
            {
                if (rows[row].Contains(item) || cols[col].Contains(item) || chancks[chanck].Contains(item)) { return false; }
            }

            rows[row].Add(item);
            cols[col].Add(item);
            chancks[chanck].Add(item);
        }
    }

    return true;
}

static List<char> ScanPriorityCheck(List<char>[] rows)
{
    Dictionary<char, int> priorityCheck = new Dictionary<char, int>();

    for (int i = 0; i < rows.Length; i++)
    {
        for (int j = 0; j < rows.Length; j++)
        {
            if (rows[i][j] != '.')
            {
                if (priorityCheck.ContainsKey(rows[i][j]))
                {
                    if (priorityCheck[rows[i][j]] == 8)
                    {
                        priorityCheck.Remove(rows[i][j]);
                    }
                    else
                    {
                        priorityCheck[rows[i][j]]++;
                    }         
                }
                else { priorityCheck.Add(rows[i][j], 0); }
                
            }
        }
    }

    List<char> result = [.. priorityCheck.Keys];
    return result;
}

static void FillingTheVoid(List<char> priorityCheck, List<char>[] rows, List<char>[] cols, List<char>[] chancks)
{

    Print(rows);

    foreach (var key in priorityCheck)
    {
        for (int row = 0; row < rows.Length; row++)
        {
            for (int col = 0; col < cols.Length; col++)
            {
                if (rows[row].Contains(key))
                {
                    if (rows[row][col] == '.') { rows[row][col] = '-'; }
                }
                if (cols[row].Contains(key))
                {
                    if (cols[row][col] == '.') { cols[row][col] = '-'; }
                }
            }
        }

    }

    Console.WriteLine();
    Print(rows);

    Console.WriteLine();
}


static void Print(List<char>[] array)
{
    Console.WriteLine();
    for (int row = 0; row < array.Length; row++)
    {
        for (int col = 0; col < array.Length; col++)
        {
            if (array[row][col] == '-') { Console.ForegroundColor = ConsoleColor.Red; }
            Console.Write("{0,6}", array[row][col] + " ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


static char[,] FillingArray(List<char>[] rows)
{
    char[,] array = new char[9, 9];
    for (int i = 0; i < rows.Length; i++)
    {
        for (int j = 0; j < rows.Length; j++)
        {
            array[i,j] = rows[i][j];
        }
    }
    return array;
}