


string input1 = "42";
string input2 = "   -42";
string input3 = "4193 with words";
string input4 = "words and 987";

//Console.WriteLine(MyAtoi(input1));
//Console.WriteLine(MyAtoi(input2));
//Console.WriteLine(MyAtoi(input3));
Console.WriteLine(MyAtoi(input4));

Console.ReadLine();


static int MyAtoi(string s)
{
    bool positive = true;

    int i = 0;
    for (; i < s.Length && s[i] == ' '; i++)
    {
    }

    if (i < s.Length)
    {
        if (s[i] == '-')
        {
            positive = false;
            i++;
        }
        else if (s[i] == '+')
        {
            i++;
        }
    }

    int val = 0;
    for (; i < s.Length && char.IsDigit(s[i]); i++)
    {
        var digit = s[i] - '0';

        if (val > (int.MaxValue - digit) / 10)
        {
            return positive ? int.MaxValue : int.MinValue;
        }

        val = val * 10 + digit;
    }

    if (positive)
    {
        return val;
    }
    else
    {
        return val * -1;
    }
}