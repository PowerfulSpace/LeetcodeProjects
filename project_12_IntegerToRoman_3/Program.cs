

using System.Text;

int input1 = 3;
int input2 = 58;
int input3 = 1994;
int input4 = 55;
int input5 = 110;
int input6 = 10;
int input7 = 45;
int input8 = 17;

Console.WriteLine(IntToRoman(input1));
Console.WriteLine(IntToRoman(input2));
Console.WriteLine(IntToRoman(input3));
Console.WriteLine(IntToRoman(input4));
Console.WriteLine(IntToRoman(input6));
Console.WriteLine(IntToRoman(input7));

Console.WriteLine(IntToRoman(input8));
Console.WriteLine(IntToRoman(input5));



Console.ReadLine();



static string IntToRoman(int num)
{
    return num switch
    {
        (>= 1000) => "M" + IntToRoman(num - 1000),
        (>= 900) => "CM" + IntToRoman(num - 900),
        (>= 500) => "D" + IntToRoman(num - 500),
        (>= 400) => "CD" + IntToRoman(num - 400),
        (>= 100) => "C" + IntToRoman(num - 100),
        (>= 90) => "XC" + IntToRoman(num - 90),
        (>= 50) => "L" + IntToRoman(num - 50),
        (>= 40) => "XL" + IntToRoman(num - 40),
        (>= 10) => "X" + IntToRoman(num - 10),
        (>= 9) => "IX" + IntToRoman(num - 9),
        (>= 5) => "V" + IntToRoman(num - 5),
        (>= 4) => "IV" + IntToRoman(num - 4),
        (>= 1) => "I" + IntToRoman(num - 1),
        _ => "",
    };
}