

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


    for (int i = 0; i < n; i++)
    {
        sb.Append('(');
        sb.Append(')');
    }
    string startValue = sb.ToString();
    string combination1tValue = string.Empty;


    AddCombination(sb.ToString(), output);

    int leftIndex = 1;
    int rigthIndex = 2;

    for (int i = 1; i < n; i++)
    {       
       leftIndex = i;
       rigthIndex = i + 1;

        while (rigthIndex + 1 < sb.Length)
        {
            left = sb[leftIndex];
            rigth = sb[rigthIndex];

            if (left != rigth)
            {
                sb.Remove(leftIndex, 2);

                sb.Insert(i, left);
                sb.Insert(i, rigth);

                AddCombination(sb.ToString(), output);
            }          

            leftIndex = rigthIndex;
            rigthIndex = rigthIndex + 1;

        }
        if(i == 1)
        {
            combination1tValue = sb.ToString();
        }
    }

    sb.Clear();
    sb.Append(combination1tValue);

    leftIndex = 1;
    rigthIndex = 2;

    int index = 1;

    while (rigthIndex + 1 < sb.Length)
    {
        left = sb[leftIndex];
        rigth = sb[rigthIndex];

        if (left != rigth)
        {
            sb.Remove(leftIndex, 2);

            sb.Insert(index, left);
            sb.Insert(index, rigth);

            AddCombination(sb.ToString(), output);
        }
        index++;
        leftIndex = rigthIndex;
        rigthIndex = rigthIndex + 1;

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