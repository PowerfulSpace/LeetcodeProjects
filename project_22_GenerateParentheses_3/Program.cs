﻿

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
    var output = new List<string>();
    char[] currentParentheses = CreateInitial(n);

    output.Add(new string(currentParentheses));

    for (int i = 0; i < n - 1; i++)
    {
        currentParentheses = CreateInitial(n);
        output = MoveParentheses(currentParentheses, i, output);
    }


    return output;
}

static char[] CreateInitial(int n)
{
    char[] currentParentheses = new char[n * 2];

    for (int i = 0; i < currentParentheses.Length; i++)
    {
        if (i < n)
        {
            currentParentheses[i] = '(';
        }
        else
        {
            currentParentheses[i] = ')';
        }
    }
    return currentParentheses;
}

static List<string> MoveParentheses(char[] currentParentheses, int iteration, List<string> output)
{
    int rightIndex = int.MaxValue;

    for (int i = currentParentheses.Length - 1; i > 0; i--)
    {
        if (currentParentheses[i] == '(')
        {
            rightIndex = i;
            break;
        }
    }

    char[] previousParentheses = new char[currentParentheses.Length];

    Array.Copy(currentParentheses, previousParentheses, currentParentheses.Length);

    while (rightIndex + iteration < currentParentheses.Length - 2)
    {
        Array.Copy(previousParentheses, currentParentheses, currentParentheses.Length);

        for (int i = 0; i < iteration + 1; i++)
        {
            int currentIndex = rightIndex - i;
            currentParentheses[currentIndex + 1] = '(';
            currentParentheses[currentIndex] = ')';
        }

        Array.Copy(currentParentheses, previousParentheses, currentParentheses.Length);
        output.Add(new string(currentParentheses));
        rightIndex++;

        for (int i = iteration - 1; i >= 0; i--)
        {
            Array.Copy(previousParentheses, currentParentheses, currentParentheses.Length);
            output = MoveParentheses(currentParentheses, i, output);
        }
    }

    if (iteration > 0)
    {
        output = MoveParentheses(currentParentheses, iteration - 1, output);
    }

    return output;
}
