
using System.Text.RegularExpressions;

string input1 = "aa";
string pattern1 = "a";

string input2 = "aa";
string pattern2 = "a*";

string input3 = "ab";
string pattern3 = ".*";

string input4 = "abс";
string pattern4 = "a***abc";

string input5 = "abcd";
string pattern5 = "a***abc";


string input6 = "abcd++";
string pattern6 = "a***abc";


Console.WriteLine(IsMatch(input1, pattern1));
Console.WriteLine(IsMatch(input2, pattern2));
Console.WriteLine(IsMatch(input3, pattern3));
Console.WriteLine(IsMatch(input4, pattern4));
Console.WriteLine(IsMatch(input5, pattern5));
Console.WriteLine(IsMatch(input6, pattern6));


Console.ReadLine();


static bool IsMatch(string s, string p)
{

    var regexMultiStar = new Regex("\\*+", RegexOptions.Multiline);
    var pattern = regexMultiStar.Replace(p, "*");
    var regex = new Regex($"^{pattern}$");
    return regex.IsMatch(s);

}
