

string input = "PAYPALISHIRING";
int rows = 4;

var result = Convert(input, rows);
Console.WriteLine();



Console.ReadLine();


static string Convert(string s, int numRows)
{
    Dictionary<int, List<char>> groupsRows = new Dictionary<int, List<char>>();
    int group = 0;

    for (int i = 0; i < numRows; i++)
    {
        groupsRows.Add(i, new List<char>());
    }

    bool ascending = false;
    int descrease = 0;

	for (int i = 0; i < s.Length; i++)
	{
        group = i % numRows;

        if (group == 0)
        {
            if(ascending == true)
            {
                descrease = numRows - 1;
                ascending = false;
            }
            else
            {
                ascending = true;
            }
        }

        if (ascending)
        {
            groupsRows[group].Add(s[i]);
        }
        else
        {
            groupsRows[group + descrease].Add(s[i]);
            descrease--;
        }

        
    }
    Console.WriteLine();

    Print(groupsRows);

    return s;
}


static void Print(Dictionary<int, List<char>> groupsRows)
{
    foreach (var key in groupsRows.Keys)
    {
        foreach (var item in groupsRows[key])
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}