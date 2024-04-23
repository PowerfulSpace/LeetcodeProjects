

using System.Text;

int num1 = 3;
int num2 = 1;

//Console.WriteLine(GenerateParenthesis(num1));
Console.WriteLine(GenerateParenthesis(num2));


Console.ReadLine();


static IList<string> GenerateParenthesis(int n)
{
    if(n < 1) return new List<string>();

    char left = '(';
    char rigth = ')';

    List<string> output = new List<string>();

    StringBuilder sb = new StringBuilder();

    sb.Append('(', n);
    sb.Append(')', n);
    output.Add(sb.ToString());
    sb.Clear();

    for (int i = 0; i < n; i++)
        sb.Append("()");

    if (!output.Contains(sb.ToString()))
    {
        output.Add(sb.ToString());
    }
        


    string startValue = sb.ToString();
    int index = 1;

    Console.WriteLine(sb);

    while (index < sb.Length - 2)
    {
        sb.Remove(index, 1);
        sb.Insert(index+=2, rigth);
        Console.WriteLine(sb);

        if (!output.Contains(sb.ToString()))
        {
            output.Add(sb.ToString());
        }

    }
    index = sb.Length - 2;
    sb.Clear();
    sb.Append(startValue);

    while (index >0)
    {
        sb.Remove(index, 1);
        sb.Insert(index -= 2, left);
        Console.WriteLine(sb);

        if (!output.Contains(sb.ToString()))
        {
            output.Add(sb.ToString());
        }
    }


    return output;
}
