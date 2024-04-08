

using System;
using System.Text;

string input = "PAYPALISHIRING";
int rows = 5;

var result = Convert(input, rows);
Console.WriteLine();



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




    return sb.ToString();
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