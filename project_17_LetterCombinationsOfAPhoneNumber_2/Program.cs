

using System.Text;
using System.Text.RegularExpressions;

string digits = "23";
string digits2 = "2";
string digits3 = "234";

//LetterCombinations(digits);
//LetterCombinations(digits2);
LetterCombinations(digits3);

Console.ReadLine();


static IList<string> LetterCombinations(string digits)
{

    if (!int.TryParse(digits, out int test))
    {
        return new List<string>();
    }

    List<string> result = new List<string>();

    Dictionary<int, List<char>> kit = new Dictionary<int, List<char>>();
    Comparison(kit);

    List<List<char>> collectionMatches = new List<List<char>>();

    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < digits.Length - 1; i++)
    {
        int key = (int)char.GetNumericValue((digits[i]));
        int key2 = (int)char.GetNumericValue((digits[i + 1]));

        foreach (var item in kit[key])
        {
            sb.Append(item);
            foreach (char item2 in kit[key2])
            {
                sb.Append(item2);
                result.Add(sb.ToString());
            }
            //result.Add(sb.ToString());
            sb.Clear();
        }
    }
    




    return result;
}

static void Comparison(Dictionary<int, List<char>> kit)
{
    int index = 97;

    kit.Add(0, new List<char>());
    kit.Add(1, new List<char>());

    for (int i = 2; i < 10; i++)
    {
        List<char> list = new List<char>();

        for (int j = 0; j < 3; j++)
        {
            list.Add((char)index);
            index++;
        }
        if (i == 7)
        {
            list.Add((char)index);
            index++;
        }
        if (i == 9)
        {
            list.Add((char)index);
            index++;
        }
        kit.Add(i, list);
    }
}