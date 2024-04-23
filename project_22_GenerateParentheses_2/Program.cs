

using System.Text;

int num1 = 3;
int num2 = 1;

//Console.WriteLine(GenerateParenthesis(num1));
Console.WriteLine(GenerateParenthesis(num2));


Console.ReadLine();


static IList<string> GenerateParenthesis(int n)
{
    if (n < 1) return new List<string>();

    char left = '(';
    char rigth = ')';

    List<string> output = new List<string>();

    StringBuilder sb = new StringBuilder();

   


    return output;
}

