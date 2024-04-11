
using System.Text.RegularExpressions;

string input1 = "aa";
string pattern1 = "a";

string input2 = "aa";
string pattern2 = "a*";

string input3 = "ab";
string pattern3 = ".*";

Console.WriteLine(IsMatch(input1,pattern1));
Console.WriteLine(IsMatch(input2,pattern2));
Console.WriteLine(IsMatch(input3,pattern3));


Console.ReadLine();


static bool IsMatch(string s, string p)
{
    Regex regex = new Regex(p);
    Match result = regex.Match(s);

    if(result.Value == s)
    {
        return true;
    }
    else
    {
        return false;
    }
}
