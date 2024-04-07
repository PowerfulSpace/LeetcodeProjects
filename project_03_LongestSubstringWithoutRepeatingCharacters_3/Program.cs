

string input1 = "abcabcbb";
string input2 = "bbbbb";
string input3 = "pwwkew";

Console.WriteLine(LengthOfLongestSubstring(input1));
Console.WriteLine(LengthOfLongestSubstring(input2));
Console.WriteLine(LengthOfLongestSubstring(input3));


Console.ReadLine();



static int LengthOfLongestSubstring(string s)
{
    Queue<char> subs = new Queue<char>();
    int res = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (subs.Contains(s[i]) == false)
        {
            subs.Enqueue(s[i]);
        }
        else
        {
            char need = s[i];
            res = Math.Max(res, subs.Count);
            while (subs.Peek() != s[i])
            {
                subs.Dequeue();
            }
            subs.Dequeue();
            subs.Enqueue(need);
        }
    }
    res = Math.Max(res, subs.Count);
    return res;
}
