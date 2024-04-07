
string input1 = "babad";
string input2 = "cbbd";
string input3 = "a";
string input4 = "ccc";
string input5 = "aacabdkacaa";

Console.WriteLine(LongestPalindrome(input1));
Console.WriteLine(LongestPalindrome(input2));
Console.WriteLine(LongestPalindrome(input3));
Console.WriteLine(LongestPalindrome(input4));
Console.WriteLine(LongestPalindrome(input5));

Console.ReadLine();



static string LongestPalindrome(string s)
{
    var longestPalindromeLength = 1;
    var longestPalindrome = s.Substring(0, 1);
    for (int i = 0; i < s.Length - 1; i++)
    {
        for (int j = s.Length - 1; j > i; j--)
        {
            if (IsPalindrome(s, i, j))
            {
                var len = j - i + 1;
                if (len > longestPalindromeLength)
                {
                    longestPalindromeLength = len;
                    longestPalindrome = s.Substring(i, len);
                }
                if (longestPalindromeLength >= len)
                    break;
            }
        }
    }
    return longestPalindrome;
}
static bool IsPalindrome(string s, int start, int end)
{
    while (s[start] == s[end] && start < end)
    {
        start++;
        end--;
    }
    return start >= end;
}