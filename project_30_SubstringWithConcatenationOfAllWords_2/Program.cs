
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

//FindSubstring(str1, words1);
//FindSubstring(str2, words2);
//FindSubstring(str3, words3);
FindSubstring(str4, words4);


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
    if (words.Length < 1 || words[0].Length > s.Length || s.Length < words.Length * words[0].Length) { return new List<int>(); }

    StringBuilder str = new StringBuilder(s);
    int wordLength = words[0].Length;

    string[] array = new string[s.Length / wordLength];

    
    List<string> lists = GetArrayOfWords(array, wordLength, s, words);
    int index = 0;

    List<int> indexes = new List<int>();

    for (int i = 0; i <= array.Length - words.Length; i++)
    {
        index = i;
        for (int j = 0; j < words.Length; j++)
        {
            lists.Add(array[index]);
            index++;
        }

        for (int j = 0; j < words.Length; j++)
        {
            if (lists.Contains(words[j]))
            {
                lists.Remove(words[j]);
            }
            else { break; }
        }
        if (lists.Count == 0)
        {
            indexes.Add(i * wordLength);
        }
        lists.Clear();
    }

    return indexes;
}


static List<string> GetArrayOfWords(string[] array,int wordLength, string mainLIne, string[] words)
{
    List<string> result = new List<string>();
    for (int i = 0; i < mainLIne.Length; i++)
    {
        char[] chars = new char[wordLength];
        for (int j = i,k = 0; j < i + wordLength; j++,k++)
        {
            chars[k] = mainLIne[j];
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
                result.Add(string.Concat(chars));
            }
        }
    }
    return result;
}