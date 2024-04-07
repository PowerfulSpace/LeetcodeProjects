


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
    int indexStart = 0;
    int indexEnd = 0;

    bool flag;

    for (int i = 0; i < s.Length; i++)
    {
        for (int j = i; j < s.Length; j++)
        {
            flag = true;

            if (s[i] == s[j])
            {
                for (int k = i, t = j; k < j; k++, t--)
                {
                    if (k == t)
                    {
                        break;
                    }
                    if (s[k] != s[t])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag && ((indexEnd + 1) - indexStart) < (j + 1) - i)
                {
                    indexStart = i;
                    indexEnd = j;
                }

            }
        }
    }
    
    return s.Substring(indexStart, (indexEnd + 1) - indexStart);
}
