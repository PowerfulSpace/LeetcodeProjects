
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

FindSubstring(str1, words1);
FindSubstring(str2, words2);
FindSubstring(str3, words3);
FindSubstring(str4, words4);
FindSubstring(str5, words5);
FindSubstring(str6, words6);


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
        if (!wordCount.ContainsKey(word)) wordCount[word] = 0;
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

            if (!seenWords.TryGetValue(currentWord, out int seenWordCount)
                || seenWordCount < wordCount[currentWord])
            {
                if (!seenWords.ContainsKey(currentWord)) seenWords[currentWord] = 0;
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


static Dictionary<int, string> GetArrayOfWords(int wordLength, string mainLIne, string[] words)
{
    Dictionary<int, string> result = new Dictionary<int, string>();
    char[] chars = new char[wordLength];

    for (int i = 0; i <= mainLIne.Length - wordLength; i++)
    {
        for (int j = 0, k = i; j < wordLength; j++, k++)
        {
            chars[j] = mainLIne[k];
        }

        foreach (var word in words)
        {
            bool flag = true;
            for (int j = 0; j < chars.Length; j++)
            {
                if (word[j] != chars[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                result.Add(i, string.Concat(chars));
                if (i + 1 < mainLIne.Length && mainLIne[i] != mainLIne[i + 1])
                {
                    i += wordLength - 1;
                }
                break;
            }
        }
    }
    return result;
}