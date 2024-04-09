

string input = "PAYPALISHIRING";
int rows = 3;

var result = Convert(input, rows);
Console.WriteLine(result);

Console.ReadLine();

static string Convert(string s, int numRows)
{
    string[] rows = new string[numRows];

    int row = 0;
    bool directionDown = true;

    foreach (char item in s)
    {
        rows[row] += item.ToString();

        if(numRows > 1)
        {
            directionDown = row == 0 ? true : row == numRows - 1 ? false : directionDown;

            row = directionDown ? row + 1 : row - 1;
        }

    }
    string output = "";

    foreach (var item in rows)
    {
        output += item;
    }


    return output;
}