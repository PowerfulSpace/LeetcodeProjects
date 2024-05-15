

string input1 = "(()";
string input2 = ")()())";
string input3 = "";
string input4 = "()(())";
string input5 = "()(()";


//Console.WriteLine(LongestValidParentheses(input1));
//Console.WriteLine(LongestValidParentheses(input2));
//Console.WriteLine(LongestValidParentheses(input3));
//Console.WriteLine(LongestValidParentheses(input4));
Console.WriteLine(LongestValidParentheses(input5));

Console.ReadLine();



static int LongestValidParentheses(string s)
{
    int count = 0;
    int inARowCount = 0;

    Stack<char> parentheses = new Stack<char>();

    int result = GetCountCombination(s,0,count, inARowCount, 0,0);
    return result;
}

static int GetCountCombination(string s,int index,int count, int inARowCount, int left, int rigth)
{
    if(index > s.Length - 1)
    {
        return count;
    }

    if (s[index] == '(')
    {
        left++;
        count = GetCountCombination(s, index + 1, count, inARowCount, left,rigth);
    }



    if (s[index] == ')')
    {
        rigth++;
        count = GetCountCombination(s, index + 1, count, inARowCount, left, rigth);
    }

    if (left < rigth) { count = 0; }
    if (left == rigth)
    {
        count = left * 2;
    }

    if (inARowCount < count) { inARowCount = count; }

    return inARowCount;
}