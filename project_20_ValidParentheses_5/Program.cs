

string input1 = "()";
string input2 = "()[]{}";
string input3 = "(]";
string input4 = "{[]}";
string input5 = "({{{{}}}))";
string input6 = "({))";
string input7 = "(}{)";
string input8 = "([]){";


//Console.WriteLine(IsValid(input1));
//Console.WriteLine(IsValid(input2));
//Console.WriteLine(IsValid(input3));
//Console.WriteLine(IsValid(input4));
Console.WriteLine(IsValid(input5));
Console.WriteLine(IsValid(input6));
Console.WriteLine(IsValid(input7));
Console.WriteLine(IsValid(input8));
;
Console.ReadLine();

static bool IsValid(string s)
{
    var stack = new Stack<char>();
    foreach (var c in s)
    {
        switch (c)
        {
            case '(':
                stack.Push(c);
                break;
            case '{':
                stack.Push(c);
                break;
            case '[':
                stack.Push(c);
                break;
            case ')':
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
                break;
            case '}':
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
                break;
            case ']':
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
                break;
        }
    }
    return stack.Count == 0;
}