

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
    var stack = new Stack<char>();
    var chars = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };

    foreach (var c in s)
    {
        if (stack.Count() == 0 && chars.ContainsKey(c))
        {
            return false;
        }

        if (!chars.ContainsKey(c))
        {
            stack.Push(c);
            continue;
        }

        if (stack.Peek() != chars[c])
        {
            return false;
        }
        else
        {
            stack.Pop();
            continue;
        }
    }

    return stack.Count() == 0;
}