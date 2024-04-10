

using System.Text;

string input = "PAYPALISHIRING";
int rows = 3;

var result = Convert(input, rows);
Console.WriteLine(result);

Console.ReadLine();

static string Convert(string s, int numRows)
{
    StringBuilder sb = new StringBuilder();
    List<char>[] rows = new List<char>[numRows];
    int k = 0;
    int direction = numRows == 1 ? 0 : -1;

    for (int i = 0; i < numRows; ++i)
        rows[i] = new List<char>();

    foreach (char c in s)
    {
        rows[k].Add(c);

        if (k == 0 || k == numRows - 1)
            direction *= -1;

        k += direction;
     }

    foreach (List<char> row in rows)
        foreach (char c in row)
            sb.Append(c);

    return sb.ToString();
}