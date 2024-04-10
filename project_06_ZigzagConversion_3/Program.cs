


using System.Text;

string input = "PAYPALISHIRING";
int rows = 4;

var result = Convert(input, rows);
Console.WriteLine(result);

Console.WriteLine();
var a = (int)System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
Console.WriteLine(a);

Console.ReadLine();

static string Convert(string s, int numRows)
{
    StringBuilder[] rows = new StringBuilder[numRows];

    for (int i = 0; i < numRows; i++)
    {
        rows[i] = new StringBuilder();
    }


    int row = 0;
    bool directionDown = true;

    foreach (var item in s)
    {
        rows[row].Append(item);

        if (numRows > 1)
        {
            directionDown = row == 0 ? true : row == numRows - 1 ? false : directionDown;

            row = directionDown == true ? row + 1 : row - 1;
        }

    }

    StringBuilder output = new StringBuilder(); 
    foreach (var item in rows)
    {
        output.Append(item);
    }

    return output.ToString();
}


