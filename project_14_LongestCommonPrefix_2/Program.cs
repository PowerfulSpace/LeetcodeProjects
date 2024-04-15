


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
    var minLength = strs.Min(str => str.Length);
    var count = strs.Length;
    var end = false;
    var index = -1;
    for (var i = 0; i < minLength; i++)
    {
        for (var j = 1; j < count; j++)
        {
            if (strs[0][i] != strs[j][i])
            {
                end = true;
                break;
            }
        }
        if (end)
            break;
        else
            index = i;
    }
    return index == -1 ? "" : strs[0].Substring(0, index + 1);
}