

using System.Text;
IList<string> res = new List<string>();

int num1 = 3;
int num2 = 1;
int num3 = 4;

//Console.WriteLine(GenerateParenthesis(num1));
//Console.WriteLine(GenerateParenthesis(num2));
Console.WriteLine(GenerateParenthesis(num3));


Console.ReadLine();


IList<string> GenerateParenthesis(int n)
{
    StringBuilder sb = new();
    Backtrack(n, n, sb);
    return res;
}


void Backtrack(int open, int closed, StringBuilder sb)
{
    if (open > closed)
        return;

    if (open == 0 && closed == 0)
    {
        string str = sb.ToString();
        res.Add(str);
        return;
    }

    if (open == closed)
    {
        sb.Append("(");
        Backtrack(open - 1, closed, sb);
        sb.Length--;
        return;
    }

    if (open < closed)
    {
        if (open > 0)
        {
            sb.Append("(");
            Backtrack(open - 1, closed, sb);
            sb.Length--;
        }

        sb.Append(")");
        Backtrack(open, closed - 1, sb);
        sb.Length--;
    }

}