




using System.Text;

string input1 = "babad";
string input2 = "cbbd";

Console.WriteLine(LongestPalindrome(input1));
Console.WriteLine(LongestPalindrome(input2));

Console.ReadLine();


static string LongestPalindrome(string s)
{
    StringBuilder sb = new StringBuilder();

    bool flag;

    for (int i = 0; i < s.Length; i++)
    {
        for (int j = i; j < s.Length; j++)
        {
            flag = true;

            if (s[i] == s[j])
            {
                for (int k = i,t = j; k < j / 2; k++,t--)
                {
                    if (s[k] != s[t])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag && sb.Length < j - i)
                {
                    if(sb.Length != 0)
                    {
                        sb.Clear();
                    }
                    
                    for (int r = i; r <= j; r++)
                    {
                        sb.Append(s[r]);
                    }
                }

            }
        }
    }
    return sb.ToString();
}
