﻿
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

    List<char> priorityCheck = ScanPriorityCheck(array);

    while (priorityCheck.Count != 0)
    {
        priorityCheck = ScanPriorityCheck(array);

        FillingTheVoid(priorityCheck, array, rows, cols, chancks);
    }
   

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

static List<char> ScanPriorityCheck(char[,] array)
{
    Dictionary<char, int> priorityCheck = new Dictionary<char, int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] != '.')
            {
                if (priorityCheck.ContainsKey(array[i,j]))
                {
                    if (priorityCheck[array[i,j]] == 8)
                    {
                        priorityCheck.Remove(array[i,j]);
                    }
                    else
                    {
                        priorityCheck[array[i,j]]++;
                    }         
                }
                else { priorityCheck.Add(array[i,j], 0); }
                
            }
        }
    }

    var sortedList = priorityCheck.OrderBy(x => x.Value);

    List<char> result = sortedList.Select(x => x.Key).ToList();
    result.Reverse();

    return result;
}

static void FillingTheVoid(List<char> priorityCheck, char[,] array, List<char>[] rows, List<char>[] cols, List<char>[] chancks)
{
    //Print(array);
    foreach (var key in priorityCheck)
    {
        //Блокировка линий по определённой цифре (key)
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (rows[row].Contains(key))
                {
                    if (array[row, col] == '.')
                    {
                        array[row, col] = '-';
                        rows[row][col] = '-';
                    }
                }
                if (cols[row].Contains(key))
                {
                    if (array[col, row] == '.')
                    {
                        array[col, row] = '-';
                        cols[col][row] = '-';
                    }
                }
            }
        }

        //Поиск на линиях не заблокированного места и заполнение его
        for (int row = 0; row < array.GetLength(0); row++)
        {
            int freePlaces = 0;
            int freeIndexY = 0;
            int freeIndexX = 0;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row,col] == '.')
                {
                    freePlaces++;
                    freeIndexY = row;
                    freeIndexX = col;
                }
                if(freePlaces > 1) { continue; }
            }

            if(freePlaces == 1)
            {
                array[freeIndexY, freeIndexX] = key;
                rows[freeIndexX][freeIndexY] = key;
                cols[freeIndexY][freeIndexX] = key;
            }
        }

        //Снятие блокировки линии
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (rows[row].Contains(key))
                {
                    if (array[row, col] == '-')
                    {
                        array[row, col] = '.';
                        rows[row][col] = '.';
                    }
                }
                if (cols[row].Contains(key))
                {
                    if (array[col, row] == '-')
                    {
                        array[col, row] = '.';
                        cols[col][row] = '.';
                    }
                }
            }
        }
    }
    //Print(array);
}


static void Print(char[,] array)
{
    Console.WriteLine();
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row,col] == '-') { Console.ForegroundColor = ConsoleColor.Red; }
            Console.Write("{0}", array[row,col] + " ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


static char[,] FillingArray(List<char>[] rows)
{
    char[,] array = new char[9,9];

    for (int i = 0; i < rows.Length; i++)
    {
        for (int j = 0; j < rows.Length; j++)
        {
            array[i,j] = rows[i][j];
        }
    }
    return array;
}
