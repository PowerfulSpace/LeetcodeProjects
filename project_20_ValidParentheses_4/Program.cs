﻿

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
    Stack<char> stack = new Stack<char>();
    foreach (char c in s)
    {
        if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
            stack.Pop();
        else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
            stack.Pop();
        else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
            stack.Pop();
        else
            stack.Push(c);
    }
    return stack.Count == 0;
}