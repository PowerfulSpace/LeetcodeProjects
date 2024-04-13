

using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

int input1 = 3;
int input2 = 58;
int input3 = 1994;
int input4 = 55;
int input5 = 110;
int input6 = 10;
int input7 = 45;
int input8 = 17;

//Console.WriteLine(IntToRoman(input1));
//Console.WriteLine(IntToRoman(input2));
//Console.WriteLine(IntToRoman(input3));
//Console.WriteLine(IntToRoman(input4));
//Console.WriteLine(IntToRoman(input6));
//Console.WriteLine(IntToRoman(input7));

Console.WriteLine(IntToRoman(input8));
Console.WriteLine(IntToRoman(input5));



Console.ReadLine();



static string IntToRoman(int num)
{
    if (Enum.IsDefined(typeof(Symbols), num))
    {
        return Enum.GetName(typeof(Symbols), num);
    }
    string digits = num.ToString();
    Stack<string> romanNumerals = new Stack<string>();
    StringBuilder sb = new StringBuilder();

    int part = (int)char.GetNumericValue(digits[digits.Length - 1]);
    int digit = 0;

    int dividerA = 1;
    int dividerB = 1;

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        dividerA *= 10;

        digit = (int)char.GetNumericValue(digits[i]);

        if (dividerA == 100 && digit * 10 == 10)
        {
            part = digit * 10;
        }
        else if (i != digits.Length - 1)
        {
            part = digit * 10 * dividerA;
        }


        if (Enum.IsDefined(typeof(Symbols), part))
        {
            romanNumerals.Push(Enum.GetName(typeof(Symbols), part));
        }
        else
        {
            if(part > 10 && part < 20)
            {
                romanNumerals.Push(Enum.GetName(typeof(Symbols), dividerA));
                digit = part - 10;
            }

            if (digit == 9)
            {
                romanNumerals.Push(Enum.GetName(typeof(Symbols), dividerA));
                romanNumerals.Push(Enum.GetName(typeof(Symbols), 1 * dividerB));
            }
            else
            {
                if (digit > 4)
                {

                    for (int j = 5; j < digit; j++)
                    {
                        romanNumerals.Push(Enum.GetName(typeof(Symbols), 1 * dividerB));
                    }
                    romanNumerals.Push(Enum.GetName(typeof(Symbols), 5 * dividerB));
                }
                else if (digit == 4)
                {
                    romanNumerals.Push(Enum.GetName(typeof(Symbols), 5 * dividerB));
                    romanNumerals.Push(Enum.GetName(typeof(Symbols), 1 * dividerB));
                }
                else
                {
                    for (int j = 0; j < digit; j++)
                    {
                        romanNumerals.Push(Enum.GetName(typeof(Symbols), 1 * dividerB));
                    }
                }

            }
        }

        dividerB *= 10;
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