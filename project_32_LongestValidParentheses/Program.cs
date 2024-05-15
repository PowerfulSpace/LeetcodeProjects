

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
    if(s == null) return 0;
    
    int left = 0; int right = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(') { left++; }
        else { right++; }
    }

    int count = 0;
    int inARowCount = 0;

    Stack<char> parentheses = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {

        if (s[i] == ')' && parentheses.Count == 0)
        {
            count = 0;
            continue;
        }
        if (s[i] == '(')
        {
            parentheses.Push(s[i]);
            continue;
        }
        if (s[i] == ')')
        {
            if (parentheses.Count > 0)
            {                
                parentheses.Pop();
                count += 2;
            }         
        }
        if(inARowCount < count)
        {
            inARowCount = count;
        }    

    }


    return inARowCount;
}