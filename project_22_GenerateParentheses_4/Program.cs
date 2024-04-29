

using System.Text;

int num1 = 1;
int num2 = 2;
int num3 = 3;
int num4 = 4;

//Console.WriteLine(GenerateParenthesis(num1));
//Console.WriteLine(GenerateParenthesis(num2));
//Console.WriteLine(GenerateParenthesis(num3));
Console.WriteLine(GenerateParenthesis(num4));


Console.ReadLine();


IList<string> GenerateParenthesis(int n)
{
    List<string> result = new List<string>();
    GenerateParenthesisHelper(result, new StringBuilder(), 0, 0, n);
    return result;
}


static void GenerateParenthesisHelper(List<string> result, StringBuilder current, int open, int close, int max)
{
    if (current.Length == max * 2)
    {
        result.Add(current.ToString());
        return;
    }

    if (open < max)
    {
        current.Append('(');
        GenerateParenthesisHelper(result, current, open + 1, close, max);
        current.Length--;
    }
    if (close < open)
    {
        current.Append(')');
        GenerateParenthesisHelper(result, current, open, close + 1, max);
        current.Length--;
    }
}


