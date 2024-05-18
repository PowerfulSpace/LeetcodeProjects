
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
    int count = 3;
    int temp = 0;
    Dictionary<char, char> list = new Dictionary<char, char>();

    for (int i = 0; i < length; i++)
    {
        count = 3;
        int index = 0;
        for (int j = temp; j < length; j++)
        {
            
            for (int k = temp; k < temp + 3; k++)
            {
                Console.Write(board[index][k] + " ");
                index++;
            }
            
            Console.WriteLine();
            if(count == 0)
            {
                if (temp + 3 < length) { temp += 3; }
                count = 3;
            }
            count--;
            
        }
        Console.WriteLine();
        if (temp + 3 < length) { temp += 3; }
       
    }

    return true;
}