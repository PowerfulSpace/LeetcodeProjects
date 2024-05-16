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
    int[] arr = new int[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        var c = s[i];

        if (c == '(')
        {
            stack.Push(i);
        }
        else
        {
            if (stack.Any())
            {
                arr[stack.Pop()] = 1;
                arr[i] = 1;
            }
        }
    }

    int max = 0;
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 1)
        {
            count++;
        }
        else
        {
            if (count > max)
            {
                max = count;
            }

            count = 0;
        }
    }

    if (count > max)
    {
        max = count;
    }

    return max;
}
