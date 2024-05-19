
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
    List<char> list = new List<char>();

    for (int i = 0; i < length; i++)
    {
        for (int x = 0; x < length; x++)
        {
            if (list.Contains(board[i][x])) { return false; }
            if (board[i][x] != '.') { list.Add(board[i][x]); }
        }
        list.Clear();
        for (int y = 0; y < length; y++)
        {
            if (list.Contains(board[y][i])) { return false; }
            if (board[y][i] != '.') { list.Add(board[y][i]); }
        }
        list.Clear();
    }

    int tempY = 0;
    int tempX = 0;
    int block = 3;
    int adding = 0;

    List<char> listChunks = new List<char>();

    while (block <= length)
    {
        while (tempY < block && tempX < length)
        {
            for (int i = tempX; i < tempX + 3; i++)
            {
                if (listChunks.Contains(board[tempY][i])) { return false; }
                if (board[tempY][i] != '.') { listChunks.Add(board[tempY][i]); }

                Console.Write(board[tempY][i] + " ");
            }
            Console.WriteLine();

            tempY++;
            if (tempY == block) { tempX += 3; tempY = adding; listChunks = new List<char>(); }
        }
        Console.WriteLine();
        block += 3;
        tempX = 0;
        adding += 3;
        tempY = adding;
    }

    return true;
}