
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

    var dic = new Dictionary<string, HashSet<int>>();

    for (var i = 0; i < 9; i++)
    {
        for (var j = 0; j < 9; j++)
        {
            if (board[i][j] == '.')
            {
                continue;
            }
            var result1 = ValidateCell(dic, i + "i", board[i][j]);
            var result2 = ValidateCell(dic, j + "j", board[i][j]);
            var result3 = ValidateCell(dic, ((i / 3) * 3 + (j / 3)).ToString(), board[i][j]);
            if (!result1 || !result2 || !result3)
            {
                return false;
            }
        }
    }

    return true;
}

static bool ValidateCell(Dictionary<string, HashSet<int>> dic, string key, int value)
{
    var exists = dic.TryGetValue(key, out var hashSet);
    if (exists)
    {
        if (hashSet.Contains(value))
        {
            return false;
        }
        else
        {
            hashSet.Add(value);
        }
    }
    else
    {
        dic.Add(key, new HashSet<int> { value });
    }

    return true;
}