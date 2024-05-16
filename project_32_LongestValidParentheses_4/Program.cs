

using System.Diagnostics.Metrics;

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
 
    Stack<int> indexes = new Stack<int>();
    bool[] coincidences = new bool[s.Length];

	for (int i = 0; i < s.Length; i++)
	{
        if (s[i] == '(')
        {
            indexes.Push(i);
        }
        else
        {
            if(indexes.Count > 0)
            {
                coincidences[indexes.Pop()] = true;
                coincidences[i] = true;
            }
        }
    }

    int combinations = 0;
    int count = 0;
    foreach (var coincidence in coincidences)
    {
        if (coincidence)
        {
            count++;
            if(combinations < count)
            {
                combinations = count;
            }
        }
        else
        {
            count = 0;
        }
    }


    return combinations;
}
