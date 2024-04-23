

using System.Text;

int num1 = 3;
int num2 = 1;
int num3 = 4;

//Console.WriteLine(GenerateParenthesis(num1));
//Console.WriteLine(GenerateParenthesis(num2));
Console.WriteLine(GenerateParenthesis(num3));


Console.ReadLine();


static IList<string> GenerateParenthesis(int n)
{
    if (n < 1) return new List<string>();

    char left = '(';
    char rigth = ')';

    List<string> output = new List<string>();

    StringBuilder sb = new StringBuilder();

    sb.Append(left, n);
    sb.Append(rigth, n);
    AddCombination(sb.ToString(), output);

    sb.Clear();
    for (int i = 0; i < n; i++)
    {
        sb.Append('(');
        sb.Append(')');
    }

    AddCombination(sb.ToString(), output);

    for (int i = 1; i < n; i++)
    {
        int leftIndex = i;
        int rigthIndex = i + 1;

        while (rigthIndex + 1 < sb.Length)
        {
            
            sb.Remove(leftIndex, 2);

            sb.Insert(i, rigth);
            sb.Insert(i, left);

            AddCombination(sb.ToString(), output);

            left = sb[leftIndex];
            rigth = sb[rigthIndex];

            leftIndex = rigthIndex;
            rigthIndex = rigthIndex + 1;

        }

    }


    return output;
}

static void AddCombination(string combination, List<string> list)
{
    if (!list.Contains(combination))
    {
        list.Add(combination);
    }
}