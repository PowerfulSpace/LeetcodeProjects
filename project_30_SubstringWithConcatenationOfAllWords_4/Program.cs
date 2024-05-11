
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
    List<int> substringStarts = new();

    int wordLength = words[0].Length;
    int substringLength = wordLength * words.Length;

    List<int> checkLastPos = new();
    List<string> checkLastWord = new();

    for (int subStart = 0; subStart <= s.Length - substringLength; subStart++)
    {
        int checkLastIndex = checkLastPos.FindIndex(x => x.Equals(subStart));
        if (checkLastIndex != -1)
        {
            string wordToCheck = checkLastWord[checkLastIndex];
            string wordInSubstring = s.Substring(subStart + substringLength - wordLength, wordLength);

            checkLastPos.RemoveAt(checkLastIndex);
            checkLastWord.RemoveAt(checkLastIndex);

            if (!wordInSubstring.Equals(wordToCheck))
                continue;

            checkLastPos.Add(subStart + wordLength);
            checkLastWord.Add(s.Substring(subStart, wordLength));
            substringStarts.Add(subStart);
            continue;
        }

        string substringToCheck = s.Substring(subStart, substringLength);
        bool foundAllWords = true;

        List<string> substrings = new();
        for (int wordStart = 0; wordStart < substringToCheck.Length; wordStart += wordLength)
        {
            substrings.Add(substringToCheck.Substring(wordStart, wordLength));
        }

        foreach (string word in words)
        {
            int index = substrings.FindIndex(x => x.Equals(word));

            if (index == -1)
            {
                foundAllWords = false;
                break;
            }

            substrings.RemoveAt(index);
        }

        if (foundAllWords)
        {
            substringStarts.Add(subStart);
            checkLastPos.Add(subStart + wordLength);
            checkLastWord.Add(substringToCheck.Substring(0, wordLength));
        }
    }

    return substringStarts;
}

