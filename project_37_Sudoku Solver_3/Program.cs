
// box size
int n;
// row size
int N;
int[][] rows;
int[][] columns;
int[][] boxes;
bool sudokuSolved = false;

char[][] board = {
 new char[]{'.','.','9','7','4','8','.','.','.'},
 new char[]{'7','.','.','.','.','.','.','.','.'},
 new char[]{'.','2','.','1','.','9','.','.','.'},
 new char[]{'.','.','7','.','.','.','2','4','.'},
 new char[]{'.','6','4','.','1','.','5','9','.'},
 new char[]{'.','9','8','.','.','.','3','.','.'},
 new char[]{'.','.','.','8','.','3','.','2','.'},
 new char[]{'.','.','.','.','.','.','.','.','6'},
 new char[]{'.','.','.','2','7','5','9','.','.'}};



Print(board);

SolveSudoku(board);
Print(board);

Console.ReadLine();




void SolveSudoku(char[][] board)
{

    n = 3;
    N = n * n;
    rows = new int[N][];
    columns = new int[N][];
    boxes = new int[N][];
    for (int k = 0; k < N; k++)
    {
        rows[k] = new int[N + 1];
        columns[k] = new int[N + 1];
        boxes[k] = new int[N + 1];
    }

    board = board;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            char num = board[i][j];
            if (num != '.')
            {
                int d = (int)char.GetNumericValue(num);
                PlaceNumber(d, i, j);
            }
        }
    }
    Backtrack(0, 0);
}

bool CouldPlace(int d, int row, int col)
{
    int idx = (row / n) * n + col / n;
    return rows[row][d] + columns[col][d] + boxes[idx][d] == 0;
}
void PlaceNumber(int d, int row, int col)
{
    int idx = (row / n) * n + col / n;
    rows[row][d]++;
    columns[col][d]++;
    boxes[idx][d]++;
    board[row][col] = (char)(d + '0');
}
void RemoveNumber(int d, int row, int col)
{
    int idx = (row / n) * n + col / n;
    rows[row][d]--;
    columns[col][d]--;
    boxes[idx][d]--;
    board[row][col] = '.';
}
void PlaceNextNumbers(int row, int col)
{
    if ((col == N - 1) && (row == N - 1))
    {
        sudokuSolved = true;
    }
    else
    {
        if (col == N - 1) Backtrack(row + 1, 0);
        else Backtrack(row, col + 1);
    }
}
void Backtrack(int row, int col)
{
    if (board[row][col] == '.')
    {
        for (int d = 1; d < 10; d++)
        {
            if (CouldPlace(d, row, col))
            {
                PlaceNumber(d, row, col);
                PlaceNextNumbers(row, col);
                if (!sudokuSolved) RemoveNumber(d, row, col);
            }
        }
    }
    else PlaceNextNumbers(row, col);
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