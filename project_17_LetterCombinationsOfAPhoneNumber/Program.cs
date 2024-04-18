

using System.Text;

string digits = "23";

LetterCombinations(digits);

Console.ReadLine();


static IList<string> LetterCombinations(string digits)
{

    if(!int.TryParse(digits, out int test))
    {
        return new List<string>();
    }

    List<string> result = new List<string>();

    Dictionary<int,List<char>> kit = new Dictionary<int,List<char>>();

    Comparison(kit);

    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < digits.Length - 1; i++)
    {
        int key = (int)char.GetNumericValue((digits[i]));
        List<char> letters = kit[key];

        int key2 = (int)char.GetNumericValue((digits[i + 1]));
        List<char> letters2 = kit[key];

        Console.WriteLine(letters[i] + " " + letters2[i]);


        Console.WriteLine();
    }




    return result;
}

static void Comparison(Dictionary<int, List<char>> kit)
{
    int index = 97;

    kit.Add(0,new List<char>());
    kit.Add(1,new List<char>());

    for (int i = 2; i < 10; i++)
    {
        List<char> list = new List<char>();

        for (int j = 0; j < 3; j++)
        {
            list.Add((char)index);
            index++;
        }
        if(i == 7)
        {
            list.Add((char)index);
            index++;
        }
        if(i == 9)
        {
            list.Add((char)index);
            index++;
        }
        kit.Add(i,list);
    }
}