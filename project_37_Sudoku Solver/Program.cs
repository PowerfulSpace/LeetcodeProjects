
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


SolveSudoku(board1);


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

    //Исправить цикл проверки
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
                        var a = array[i, j];
                        priorityCheck.Remove(array[i,j]);
                    }
                    else
                    {
                        priorityCheck[array[i,j]]++;
                    }         
                }
                else { priorityCheck.Add(array[i,j], 1); }
                
            }
        }
    }
    var sortedList = priorityCheck.OrderByDescending(x => x.Value);

    List<char> result = sortedList.Select(x => x.Key).ToList();
    //result.Reverse();

    if(result.Count == 7)
    {
        Console.WriteLine();
        Print(array);
    }

    return result;
}

static void FillingTheVoid(List<char> priorityCheck, char[,] array, List<char>[] rows, List<char>[] cols, List<char>[] chancks)
{
    Print(array);
    foreach (var key in priorityCheck)
    {

        //Блокировка линий по определённой цифре (key) + блокировка элементов в чанка
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if(key == '1')
                {
                    Console.WriteLine();
                }
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
                        cols[row][col] = '-';
                    }
                }

            }   
        }

        Print(array);

        //Заполнение чанков
        BlockChanks(array, chancks);

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

        bool found = false;
        //Поиск элементов в чанках и установка значения
        for (int i = 0; i < chancks.Length; i++)
        {
            if (chancks[i].Contains(key)) { continue; }

            if (chancks[i].Where(x => x == '.').Count() != 1) { continue; }

            int index = chancks[i].IndexOf('.');

            //Проверка на подлинность блокирповки
            if (key == '1' && i == 6)
            {
                Print(array);
                Console.WriteLine();
            }

            chancks[i][index] = key;
            found = true;
        }

        if (found)
        {
            Overwriting(array, rows, cols, chancks);
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

        //Снятие блокировки с чанков
        BlockChanks(array, chancks);

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

static void BlockChanks(char[,] array, List<char>[] chancks)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            int chanck = ((row / 3) * 3) + (col / 3);
            int chanckIndex = ((row % 3) * 3) + (col % 3);

            chancks[chanck][chanckIndex] = array[row, col];
        }
    }
}


//Допилить метод, позволяющий перезаписать данные с чанков
static void Overwriting(char[,] array, List<char>[] rows, List<char>[] cols, List<char>[] chancks)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            int chanck = ((row / 3) * 3) + (col / 3);
            int chanckIndex = ((row % 3) * 3) + (col % 3);

            array[row, col] = chancks[chanck][chanckIndex];

            rows[row][col] = chancks[chanck][chanckIndex];
            cols[col][row] = chancks[chanck][chanckIndex];
        }
    }
}

