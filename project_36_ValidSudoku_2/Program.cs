
using System;

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
    int count = 0;
    int temp = 0;
    int level = 3;
    int adding = 0;


    List<char> list = new List<char>();

    while (level <= length)
    {
        while (count < level && temp < length)
        {           
            for (int i = temp; i < temp + 3; i++)
            {
                if (list.Contains(board[count][i])) { return false; }
                if(board[count][i] != '.') { list.Add(board[count][i]); }
                
                Console.Write(board[count][i] + " ");
            }
            Console.WriteLine();

            count++;
            if (count == level) { temp += 3; count = adding; list = new List<char>(); }
        }
        Console.WriteLine();
        level += 3;
        temp = 0;
        adding += 3;
        count = adding;
    }

    return true;
}