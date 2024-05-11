
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
    if(s == null || words == null) { return new List<int>(); }

    List<int> result = new List<int>();

    int wordLength = words[0].Length;
    int wordCount = words.Length;

    Dictionary<string,int> foundWords = new Dictionary<string, int>();

    foreach (var word in words)
    {
        if (foundWords.ContainsKey(word))
        {
            foundWords[word]++;
        }
        else
        {
            foundWords.Add(word, 1);
        }
    }


    for (int i = 0; i < wordLength; i++)
    {
        int left = i;
        int count = 0;
        Dictionary<string, int> countWords = new Dictionary<string, int>();

        for (int rigth = left; rigth < s.Length - wordLength; rigth+= wordLength)
        {
            string word = s.Substring(rigth, wordLength);

            if (foundWords.ContainsKey(word))
            {
                if (countWords.ContainsKey(word))
                {
                    countWords[word]++;
                }
                else
                {
                    countWords.Add(word, 1);
                }
                count++;


                while (countWords[word] > foundWords[word])
                {
                    countWords[word]--;
                    count--;
                    left += wordLength;
                }

                if(count == wordCount)
                {
                    result.Add(left);
                }
            }
            else
            {
                countWords.Clear();
                count = 0;
                left += wordLength;
            }

        }
    }



    return result;
}


