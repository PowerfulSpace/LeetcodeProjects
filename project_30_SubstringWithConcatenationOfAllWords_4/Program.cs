
using System;
using System.Text;

string str1 = "barfoothefoobarman";
string[] words1 = { "foo", "bar" };

string str2 = "wordgoodgoodgoodbestword";
string[] words2 = { "word", "good", "best", "word" };

string str3 = "barfoofoobarthefoobarman";
string[] words3 = { "bar", "foo", "the" };

string str4 = "lingmindraboofooowingdingbarrwingmonkeypoundcake";
string[] words4 = { "fooo", "barr", "wing", "ding", "wing" };

string str5 = "aaaaa";
string[] words5 = { "aa", "aa" };



Array.ForEach(FindSubstring(str1, words1).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(FindSubstring(str2, words2).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(FindSubstring(str3, words3).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(FindSubstring(str4, words4).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(FindSubstring(str5, words5).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
    foreach (var word in words)
    {
        if (originDict.ContainsKey(word))
        {
            originDict[word]++;
        }
        else
        {
            originDict[word] = 1;
        }
    }

    var totalWords = words.Length;
    var wordLength = words[0].Length;

    for (var i = 0; i < wordLength; i++)
    {
        // sliding windows
        processSubstring(new Dictionary<string, int>(originDict), i, wordLength, totalWords, s);
    }

    return res;
}


static void processSubstring(Dictionary<string, int> dict, int start, int wordLen, int totalWords, string s)
{
    var l = start;
    var r = start + wordLen - 1;

    while (r < s.Length)
    {
        // Console.WriteLine("start: "+start);
        // Console.WriteLine("l: "+l);
        // Console.WriteLine("r: "+r);
        var key = s.Substring(l, wordLen);
        // Console.WriteLine("key: "+key);

        if (!dict.ContainsKey(key))
        {
            start = r + 1;
            l = start;
            r = l + wordLen - 1;
            dict = new Dictionary<string, int>(originDict);
        }
        else if (dict[key] == 0)
        {
            dict[s.Substring(start, wordLen)]++;
            start += wordLen;
        }
        else
        {
            // Console.WriteLine("key count: "+dict[key]);
            if (r - start == wordLen * totalWords - 1)
            {
                // found 
                // Console.WriteLine("found");
                res.Add(start);
                dict[key]--;
                dict[s.Substring(start, wordLen)]++;
                start += wordLen;
                l += wordLen;
                r += wordLen;
            }
            else
            {
                dict[key]--;
                l += wordLen;
                r += wordLen;
            }
        }
    }
}