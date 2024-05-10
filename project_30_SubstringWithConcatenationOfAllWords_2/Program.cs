
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

string str6 = "wordgoodgoodgoodbestword";
string[] words6 = { "word", "good", "best", "good" };

//FindSubstring(str1, words1);
//FindSubstring(str2, words2);
//FindSubstring(str3, words3);
//FindSubstring(str4, words4);
//FindSubstring(str5, words5);
//FindSubstring(str6, words6);

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
Array.ForEach(FindSubstring(str6, words6).ToArray(), x => Console.Write(x + " "));
Console.WriteLine();


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
    var indices = new List<int>();
    int wordLength = words[0].Length;
    int totalWords = words.Length;
    int concatLength = wordLength * totalWords;
    int lastIndex = s.Length - concatLength;

    var wordCount = new Dictionary<string, int>();
    foreach (var word in words)
    {
        if (!wordCount.ContainsKey(word))
        {
            wordCount[word] = 0;
        }
        wordCount[word]++;
    }

    for (int i = 0; i <= lastIndex; i++)
    {
        var seenWords = new Dictionary<string, int>();

        int concatWords = 0;

        while (concatWords < totalWords)
        {
            string currentWord = s.Substring(i + concatWords * wordLength, wordLength);

            if (!wordCount.ContainsKey(currentWord)) break;

            if (!seenWords.TryGetValue(currentWord, out int seenWordCount) || seenWordCount < wordCount[currentWord])
            {
                if (!seenWords.ContainsKey(currentWord))
                {
                    seenWords[currentWord] = 0;
                }
                seenWords[currentWord]++;
                concatWords++;
            }
            else
            {
                break;
            }
        }

        if (concatWords == totalWords)
        {
            indices.Add(i);
        }
    }

    return indices;
}


