


using System.Text.RegularExpressions;

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

    string[]  elements = s.Split(' ');

    string pattern = @"-?\d+";
    Regex regex = new Regex(pattern);

    Match match = null;

    foreach (string element in elements)
    {
        if (regex.IsMatch(element))
        {
            match = regex.Match(s);
        }
    }

    int result = 0;
    if (match.Value != null)
    {
        result = int.Parse(match.Value);

    }

    return result;
}