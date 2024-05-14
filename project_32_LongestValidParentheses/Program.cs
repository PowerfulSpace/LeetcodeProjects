

string input1 = "(()";
string input2 = ")()())";
string input3 = "";


Console.WriteLine(LongestValidParentheses(input1));
Console.WriteLine(LongestValidParentheses(input2));
Console.WriteLine(LongestValidParentheses(input3));

Console.ReadLine();



static int LongestValidParentheses(string s)
{
    if(s == null) return 0;
    int count = 0;

    for (int i = 1; i < s.Length; i++)
    {
        if (s[i - 1] == '(')
        {
            if (s[i] == ')')
            {
                count+=2;
            }
        }
    }


    return count;
}