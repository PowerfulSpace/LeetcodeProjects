

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
    Stack<int> st = new();
    st.Push(-1);

    int res = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            st.Push(i);
        }
        else
        {
            st.Pop();
            if (st.Count == 0)
            {
                st.Push(i);
            }
            else
            {
                res = Math.Max(res, i - st.Peek());
            }
        }
    }

    return res;
}
