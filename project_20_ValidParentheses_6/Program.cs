

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

//Вернуться к этой задаче
static bool IsValid(string s)
{
    HashSet<char> open = new() { '(', '[', '{' };
    Stack<char> stk = new();
    foreach (var c in s)
    {
        if (open.Contains(c))
        {
            stk.Push(c);
            continue;
        }

        if (stk.Count() == 0 || Math.Abs(c - stk.Pop()) > 2)
            return false;
    }

    return stk.Count() == 0;
}