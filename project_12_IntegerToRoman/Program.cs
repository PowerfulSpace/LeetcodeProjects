

using System.Text;

int input1 = 3;
int input2 = 58;
int input3 = 1994;
int input4 = 55;

//Console.WriteLine(IntToRoman(input1));
//Console.WriteLine(IntToRoman(input2));
//Console.WriteLine(IntToRoman(input3));
Console.WriteLine(IntToRoman(input4));

Console.ReadLine();



static string IntToRoman(int num)
{

    string digits = num.ToString();
    Stack<string> romanNumerals = new Stack<string>();
    StringBuilder sb = new StringBuilder();

    int part = (int)char.GetNumericValue(digits[digits.Length - 1]);

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        int digit = (int)char.GetNumericValue(digits[i]);

        if (i != digits.Length - 1)
        {
            part = digit * 10;
        }


        if(Enum.IsDefined(typeof(Symbols), part))
        {
            romanNumerals.Push(Enum.GetName(typeof(Symbols), part));
            //Console.WriteLine(Enum.GetName(typeof(Symbols), part));
        }
        else
        {

        }
        
    }

    while (romanNumerals.Count > 0)
    {
        sb.Append(romanNumerals.Pop());
    }

    return sb.ToString();
}

enum Symbols
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000
}