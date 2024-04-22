
string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "{[]}";


//Console.WriteLine(IsValid(input1));
//Console.WriteLine(IsValid(input2));
//Console.WriteLine(IsValid(input3));
Console.WriteLine(IsValid(input4));
Console.ReadLine();

static bool IsValid(string s)
{
    Dictionary<char, char> bracket = new Dictionary<char, char>()
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}'
    };

    for (int i = 0; i < s.Length-1; i++)
    {

        if (bracket.ContainsKey(s[i]))
        {
            if (s[i + 1] != bracket[s[i]])
            {
                return false;
            }
        }

    }

    return true;
}