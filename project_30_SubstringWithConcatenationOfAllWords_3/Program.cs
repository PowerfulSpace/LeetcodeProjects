
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

//Array.ForEach(FindSubstring(str1, words1).ToArray(), x => Console.Write(x + " "));
//Console.WriteLine();
//Array.ForEach(FindSubstring(str2, words2).ToArray(), x => Console.Write(x + " "));
//Console.WriteLine();
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
    var result = new List<int>();
    if (s == null || words == null || words.Length == 0) return result;

    int wordLength = words[0].Length;
    int concatLength = wordLength * words.Length;
    if (s.Length < concatLength) return result;

    var wordCount = new Dictionary<string, int>();
    foreach (string word in words)
    {
        if (wordCount.ContainsKey(word))
        {
            wordCount[word]++;
        }
        else
        {
            wordCount.Add(word, 1);
        }
    }

    for (int i = 0; i < wordLength; i++)
    {
        int left = i;
        var wordsFound = new Dictionary<string, int>();
        int count = 0;

        for (int right = i; right <= s.Length - wordLength; right += wordLength)
        {
            string word = s.Substring(right, wordLength);

            if (wordCount.ContainsKey(word))
            {
                if (wordsFound.ContainsKey(word))
                {
                    wordsFound[word]++;
                }
                else
                {
                    wordsFound.Add(word, 1);
                }

                count++;

                while (wordsFound[word] > wordCount[word])
                {
                    string leftWord = s.Substring(left, wordLength);
                    wordsFound[leftWord]--;
                    count--;
                    left += wordLength;
                }

                if (count == words.Length)
                {
                    result.Add(left);
                }
            }
            else
            {
                wordsFound.Clear();
                count = 0;
                left = right + wordLength;
            }
        }
    }

    return result;
}

