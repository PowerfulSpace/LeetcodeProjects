

using System;
using System.Text;

string input = "PAYPALISHIRING";
int rows = 4;

var result = Convert(input, rows);
Console.WriteLine();



Console.ReadLine();


static string Convert(string s, int numRows)
{
    int column = (int)Math.Ceiling((decimal)numRows / 2);
    int rows = 0;
    char[,] chars = new char[numRows + (numRows / 2),];
    


    return s;
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