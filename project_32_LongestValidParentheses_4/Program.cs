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

    Stack<int> stack = new Stack<int>();
    stack.Push(-1);
    int maxLength = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            stack.Push(i);
        }
        else
        {
            stack.Pop();

            if (stack.Count == 0)
            {
                stack.Push(i);
            }
            else
            {
                maxLength = Math.Max(maxLength, i - stack.Peek());
            }
        }
    }
    return maxLength;
}
