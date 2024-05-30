
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