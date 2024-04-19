

using System.Text;
using System.Text.RegularExpressions;

string digits = "23";
string digits2 = "2";
string digits3 = "234";

LetterCombinations(digits);
//LetterCombinations(digits2);
//LetterCombinations(digits3);

Console.ReadLine();


static IList<string> LetterCombinations(string digits)
{

    if (digits.Length == 0) return new List<string>();
    Dictionary<string, string> kit = new Dictionary<string, string>()
    {
        ["2"] = "abc",
        ["3"] = "def",
        ["4"] = "ghi",
        ["5"] = "jkl",
        ["6"] = "mno",
        ["7"] = "pqrs",
        ["8"] = "tuv",
        ["9"] = "wxyz",
    };

    List<string> result = new List<string>();

    result = CreateCombinations(result, "", digits, kit);


    return result;
}

static List<string> CreateCombinations(List<string> list, string value, string digits, Dictionary<string, string> kit)
{

    foreach (var item in kit[digits.Substring(0, 1)])
    {
        string temporaryMeaning = value + item;

        if (digits.Length > 1)
        {
            list = CreateCombinations(list, temporaryMeaning, digits.Substring(1), kit);
        }
        else
        {
            list.Add(temporaryMeaning);
        }
    }

    return list;
}