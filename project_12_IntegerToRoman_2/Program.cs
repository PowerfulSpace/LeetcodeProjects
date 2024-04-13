

using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


int input1 = 3;
int input2 = 58;
int input3 = 1994;
int input4 = 55;
int input5 = 9582;

//Console.WriteLine(IntToRoman(input1));
//Console.WriteLine(IntToRoman(input2));
//Console.WriteLine(IntToRoman(input3));
//Console.WriteLine(IntToRoman(input4));
Console.WriteLine(IntToRoman(input5));




Console.ReadLine();



static string IntToRoman(int num)
{
    Dictionary<int, string> romanMap = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

    StringBuilder roman = new StringBuilder();
    foreach (var kvp in romanMap)
    {
        while (num >= kvp.Key)
        {
            roman.Append(kvp.Value);
            num -= kvp.Key;
        }
    }

    return roman.ToString();
}
