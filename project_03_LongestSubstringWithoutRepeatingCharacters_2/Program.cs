

string input1 = "abcabcbb";
string input2 = "bbbbb";
string input3 = "pwwkew";

Console.WriteLine(LengthOfLongestSubstring(input1));
Console.WriteLine(LengthOfLongestSubstring(input2));
Console.WriteLine(LengthOfLongestSubstring(input3));


Console.ReadLine();



static int LengthOfLongestSubstring(string s)
{
    if (s.Length < 2)
    {
        return s.Length;
    }
    int k = 0, maxLen = 0, count = 0;

    for (int i = 1; i < s.Length; i++)
    {
        for (int j = k; j < i; j++)
        {
            if (s[i] == s[j])
            {
                k = j + 1;
            }
        }
        count = i - k + 1;

        if (count > maxLen)
        {
            maxLen = count;
        }
    }

    return maxLen;
}
