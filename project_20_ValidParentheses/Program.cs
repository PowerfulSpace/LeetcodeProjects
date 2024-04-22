
using System.Text;

string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "{[]}";
string input5 = "({{{{}}}))";
string input6 = "({))";
string input7 = "(}{)";
string input8 = "([]){";


Console.WriteLine(IsValid(input1));
Console.WriteLine(IsValid(input2));
Console.WriteLine(IsValid(input3));
Console.WriteLine(IsValid(input4));
Console.WriteLine(IsValid(input5));
Console.WriteLine(IsValid(input6));
Console.WriteLine(IsValid(input7));
Console.WriteLine(IsValid(input8));
;
Console.ReadLine();

static bool IsValid(string s)
{
    if (s.Length < 2 || s.Length % 2 > 0) { return false; }
    Dictionary<char, char> bracket = new Dictionary<char, char>()
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}'
    };
    StringBuilder value = new StringBuilder(s);
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < value.Length - 1; i++)
    {

        if (result.Length > 0)
        {
            if (bracket.ContainsKey(value[i]) && result[result.Length - 1] == bracket[value[i]])
            {
                result = result.Remove(result.Length - 1, 1);
                value = value.Remove(i, 2);
            }
            else if (bracket.ContainsKey(value[i]) && value[i] == bracket[value[i]])
            {
                return false;
            }
        }

        if (bracket.ContainsKey(value[i]) && bracket[value[i]] == value[i + 1])
        {
            value = value.Remove(i, 2);
            if (result.Length > 0)
            {
                result = result.Remove(result.Length - 1, 1);
            }
            i = i == 0 ? i - 1 : i - 2;

        }
        else
        {
            if (!bracket.ContainsKey(value[i]))
            {
                return false;
            }
            result.Append(value[i]);
        }
    }


    if (result.Length > 0 || value.Length > 0) { return false; }


    return true;
}