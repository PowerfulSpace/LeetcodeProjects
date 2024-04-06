

string input = "abcabcbb";
//string input = "bbbbb";
//string input = "pwwkew";



int result = LengthOfLongestSubstring(input);
Console.WriteLine();
Console.WriteLine(result);

Console.ReadLine();


static int LengthOfLongestSubstring(string s)
{
    Dictionary<char, int> chars = new Dictionary<char, int>();
    int count = 0;
    int maxCount = 0;

    for (int i = 0; i < s.Length; i++)
    {
        Console.Write(s[i]);

        if (chars.ContainsKey(s[i]))
        {

            int index = chars[s[i]];

            chars.Clear();
            count = 0;
            i = index;
        }
        else
        {
            chars.Add(s[i], i);
            count++;

            if (count >= maxCount)
            {
                maxCount = count;
            }
        }
    }
    return maxCount;
}