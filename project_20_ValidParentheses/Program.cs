
string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "{[]}";
string input5 = "({{{{}}}))";
string input6 = "({))";


//Console.WriteLine(IsValid(input1));
//Console.WriteLine(IsValid(input2));
//Console.WriteLine(IsValid(input3));
//Console.WriteLine(IsValid(input4));
Console.WriteLine(IsValid(input5));
Console.WriteLine(IsValid(input6));
Console.ReadLine();

static bool IsValid(string s)
{
    Dictionary<char, char> bracket = new Dictionary<char, char>()
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}'
    };

    if(LineTraversal(s, bracket) == "")
    {
        return true;
    }

    return false;
}
static string LineTraversal(string s, Dictionary<char, char> bracket)
{
    if(s == "") { return s; }

    string value = s;

    for (int i = 0; i < Math.Floor((decimal)(s.Length - 1) / 2); i++)
    {
        if (bracket.ContainsKey(s[i]))
        {
            if (s[i + 1] != bracket[s[i]])
            {
                value = LineTraversal(s.Substring(1), bracket);

                if (bracket[s[i]].ToString() == value)
                {
                    return LineTraversal(value.Substring(1), bracket);
                }
            }
            else
            {
                value = LineTraversal(value.Substring(2), bracket);
                return value;
            }
        }
        else { return value; }

    }

    return value;
}