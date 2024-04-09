using System.Collections.Generic;
using System.Text;

string input = "PAYPALISHIRING";
int rows = 4;

var result = Convert(input, rows);
Console.WriteLine(result);



Console.ReadLine();


static string Convert(string s, int numRows)
{
    int addChars = (int)Math.Ceiling((decimal)numRows / 2);
    int countCharsEmpty = (numRows - 1) * addChars;

    StringBuilder sb = new StringBuilder(s.Length * 2);
    int index = 0;


    if (numRows >= 4)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (index % numRows == 0 && i != 0)
            {
                index = 0;

                sb.Append('-');
                sb.Append(s[i]);
                i++;
                for (int j = 0; j < numRows; j++)
                {
                    sb.Append('-');
                }
                sb.Append(s[i]);
                i++;
                sb.Append('-');
            }
            if (i < s.Length)
            {
                index++;
                sb.Append(s[i]);
            }
        }
    }
    else
    {
        if (numRows == 3)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (index % numRows == 0 && i != 0)
                {
                    index = 0;

                    sb.Append('-');
                    sb.Append(s[i]);
                    i++;
                    sb.Append('-');
                }
                if (i < s.Length)
                {
                    index++;
                    sb.Append(s[i]);
                }
            }
        }
        if(numRows == 2)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (index % numRows == 0 && i != 0)
                {
                    index = 0;

                    sb.Append(s[i+1]);
                    sb.Append(s[i]);
                    i += 2;
                }
                if (i < s.Length)
                {
                    index++;
                    sb.Append(s[i]);
                }
            }
        }
        if (numRows == 1)
        {
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
            }
        }
    }
  
    int countLists = (int)Math.Ceiling((decimal)sb.Length / numRows);

    List<List<char>> lists = new List<List<char>>();

    for (int i = 0; i < countLists; i++)
    {
        lists.Add(new List<char>());
    }

    int indexRows = 0;

    int isReverse = 0;
    int countReverse = 0;

    foreach (var item in lists)
    {
        for (int i = 0; i < numRows; i++)
        {
            if(indexRows < sb.Length)
            {
                item.Add(sb[indexRows]);
                indexRows++;
            }
            else { break; }
          
        }

        if (numRows > 3 && countReverse > 0)
        {
            item.Reverse();
            countReverse--;
        }
        else
        {
            countReverse = numRows - 2;
        }
        isReverse++;
    }

    StringBuilder sb2 = new StringBuilder();

    char[,] chars = new char[numRows, numRows*2];

    for (int i = 0; i < lists.Count; i++)
    {
        for (int j = 0; j < lists[i].Count; j++)
        {
            chars[j, i] = lists[i][j];
        }
    }

    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            sb2.Append(chars[i, j]);
            Console.Write(chars[i,j] + " ");
        }
        Console.WriteLine();
    }

    string myString = sb2.ToString().Replace('-','\0');
    return myString.ToString();
}


static void Print(char[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {

        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write(groups[i,j] + " ");
        }
        Console.WriteLine();
    }
}