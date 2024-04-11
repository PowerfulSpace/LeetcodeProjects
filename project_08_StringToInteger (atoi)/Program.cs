


using System.Text.RegularExpressions;

string input1 = "42";
string input2 = "   -42";
string input3 = "4193 with words";
string input4 = "words and 987";
string input5 = "words and 987419341934193";
string input6 = "words and 987419341934193";
string input7 = "words -987 and ";
string input8 = "words and +-+987";
string input9 = "words and +";
string input10 = "words and 00987";
string input11 = ".1";
string input12 = "w1";

Console.WriteLine(MyAtoi(input1));
Console.WriteLine(MyAtoi(input2));
Console.WriteLine(MyAtoi(input3));
Console.WriteLine(MyAtoi(input4));
Console.WriteLine(MyAtoi(input5));
Console.WriteLine(MyAtoi(input6));
Console.WriteLine(MyAtoi(input7));
Console.WriteLine(MyAtoi(input8));
Console.WriteLine(MyAtoi(input9));
Console.WriteLine(MyAtoi(input10));
Console.WriteLine(MyAtoi(input11));
Console.WriteLine(MyAtoi(input12));

Console.ReadLine();


static int MyAtoi(string s)
{
    s = s.Trim();
    string[] elements = s.Split(' ');

    string pattern = @"^(-?||\+?)\d+";
    Regex regex = new Regex(pattern);
    Match match = null;

    if (regex.IsMatch(elements[0]))
    {
        match = regex.Match(s);
    }

    int result = 0;
    if (match != null)
    {
        bool noRange = int.TryParse(match.Value, out result);

        if (!noRange)
        {
            if (match.Value.Contains('-'))
            {
                result = int.MinValue;
            }
            else
            {
                result = int.MaxValue;
            }
        }
    }

    return result;
}