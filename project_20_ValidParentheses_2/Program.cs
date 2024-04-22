

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

    if (s == null || s == string.Empty || s.Length == 1) return false;

    Stack<char> symbolsStack = new Stack<char>();
    int symbolStackCounter = 0;
    foreach (char c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            symbolsStack.Push(c);
            symbolStackCounter++;
        }
        else
        {
            if (symbolStackCounter > 0 && symbolsStack.Count > 0)
            {
                char poppedSymbol = symbolsStack.Pop();
                if ((poppedSymbol == '[' && c == ']')
                    || (poppedSymbol == '{' && c == '}')
                    || (poppedSymbol == '(' && c == ')'))
                {
                    symbolStackCounter--;
                }
            }
            else
            {
                symbolStackCounter++;
                break;
            }
        }
    }

    return symbolStackCounter == 0;
}