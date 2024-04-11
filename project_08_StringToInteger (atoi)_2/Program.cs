
string input1 = "42";
string input2 = "   -42";
string input3 = "4193 with words";
string input4 = "words and 987";
string input5 = ".1";
string input6 = "w1";
string input7 = "1w23";
string input8 = "987419341934193";

//Console.WriteLine(MyAtoi(input1));
//Console.WriteLine(MyAtoi(input2));
//Console.WriteLine(MyAtoi(input3));
//Console.WriteLine(MyAtoi(input4));
//Console.WriteLine(MyAtoi(input5));
//Console.WriteLine(MyAtoi(input7));
Console.WriteLine(MyAtoi(input8));

Console.ReadLine();


static int MyAtoi(string s)
{
    s = s.TrimStart();

    if (s.Length == 0)
    {
        return 0;
    }

    int startIndex = 0;
    int sign;

    if (s[startIndex] == '-')
    {
        startIndex++;
        sign = -1;
    }
    else if ((s[startIndex] == '+'))
    {
        startIndex++;
        sign = 1;
    }
    else if (Char.IsDigit(s[startIndex]))
    {
        sign = 1;
    }
    else
    {
        return 0;
    }

    int val = 0;

    for (int i = startIndex; i < s.Length && Char.IsDigit(s[i]); i++)
    {
        int digit = s[i] - '0';


        if (val > (int.MaxValue - digit) / 10)
        {
            return (sign == 1) ? int.MaxValue : int.MinValue;
        }

        val = val * 10 + digit;
    }

    return val * sign;
}