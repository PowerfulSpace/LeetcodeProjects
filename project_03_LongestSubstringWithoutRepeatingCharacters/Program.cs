string input = "abcabcbb";

//int result = LengthOfLongestSubstring(input);
//Console.WriteLine(result);

int result = Method(input);
Console.WriteLine();
Console.WriteLine(result);

Console.ReadLine();



static int Method(string s)
{
    List<char> chars = new List<char>();
    int count = 0;
    int maxCount = 0;

    for (int i = 0; i < s.Length; i++)
    {
        Console.Write(s[i]);

        if (chars.Contains(s[i]))
        {
            int index = s.IndexOf(s[i]);

            chars.Clear();
            count = 0;
            i = index;
        }
        else
        {
            chars.Add(s[i]);
            count++;

            if (count >= maxCount)
            {
                maxCount = count;
            }  
        }
    }
    return maxCount;
}

//static int LengthOfLongestSubstring(string s)
//{
//}