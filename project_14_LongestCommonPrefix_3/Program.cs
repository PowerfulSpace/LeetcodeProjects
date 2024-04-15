


string[] input1 = { "flower", "flow", "flight" };
string[] input2 = { "dog", "racecar", "car" };
string[] input3 = { "", "b" };
string[] input4 = { "reflower", "flow", "flight" };
string[] input5 = { "flower", "flower", "flower", "flower" };
string[] input6 = { "aaa", "aa", "aaa" };


Console.WriteLine(LongestCommonPrefix(input1));
Console.WriteLine(LongestCommonPrefix(input2));
Console.WriteLine(LongestCommonPrefix(input3));
Console.WriteLine(LongestCommonPrefix(input4));
Console.WriteLine(LongestCommonPrefix(input5));
Console.WriteLine(LongestCommonPrefix(input6));


Console.ReadLine();

static string LongestCommonPrefix(string[] strs)
{
    int i = 0;
    for (; i < 200; i++)
    {
        if (i >= strs[0].Length) break;
        char a = strs[0][i];
        if (Array.Exists(strs, s => i >= s.Length || a != s[i])) break;
    }
    return strs[0][..i];
}