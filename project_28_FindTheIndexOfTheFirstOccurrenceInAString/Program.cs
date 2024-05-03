


string haystack1 = "sadbutsad";
string needle1= "sad";

string haystack2 = "leetcode";
string needle2 = "leeto";

//Console.WriteLine(StrStr(haystack1, needle1));
Console.WriteLine(StrStr(haystack2, needle2));

Console.ReadLine();



static int StrStr(string haystack, string needle)
{
    return haystack.IndexOf(needle);
}