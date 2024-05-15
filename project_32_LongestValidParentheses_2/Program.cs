

string input1 = "(()";
string input2 = ")()())";
string input3 = "";
string input4 = "()(())";
string input5 = "()(()";


Console.WriteLine(LongestValidParentheses(input1));
Console.WriteLine(LongestValidParentheses(input2));
Console.WriteLine(LongestValidParentheses(input3));
Console.WriteLine(LongestValidParentheses(input4));
Console.WriteLine(LongestValidParentheses(input5));

Console.ReadLine();



static int LongestValidParentheses(string s)
{
    if (s.Length <= 1) return 0;

    bool[] matching = new bool[s.Length];

    Stack<int> openingIndexes = new Stack<int>();

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if (c == '(')
        {
            openingIndexes.Push(i);
        }
        else
        {
            if (openingIndexes.Count != 0)
            {
                int openingIndex = openingIndexes.Pop();
                matching[i] = true;
                matching[openingIndex] = true;
            }
        }
    }

    int longest = 0;
    int current = 0;
    foreach (bool match in matching)
    {
        if (match)
        {
            current++;
            if (current > longest)
            {
                longest = current;
            }
        }
        else
        {
            current = 0;
        }
    }

    return longest;
}
