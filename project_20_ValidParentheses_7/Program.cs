

string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "{[]}";
string input5 = "({{{{}}}))";
string input6 = "({))";
string input7 = "(}{)";
string input8 = "([]){";


//Console.WriteLine(IsValid(input1));
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
    if (s.Length % 2 != 0) return false;
    Dictionary<char, char> Check = new Dictionary<char, char>();
    Check['('] = ')';
    Check['['] = ']';
    Check['{'] = '}';
    Stack<char> Stack = new Stack<char>();
    foreach (char c in s)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            Stack.Push(c);
        }
        else
        {
            if (Stack.Count == 0) return false;
            char top = Stack.Pop();
            if (Check[top] != c) return false;
        }
    }
    return Stack.Count == 0;
}