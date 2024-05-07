
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
    if (words.Length < 1 || words[0].Length > s.Length || s.Length < words.Length * words[0].Length) { return new List<int>(); }
    int wordLength = words[0].Length;
    int sumWords = wordLength * words.Length;

    Dictionary<int, string> dictionary = GetArrayOfWords(wordLength, s, words);

    List<string> lists = new List<string>();
    int key = 0;
    int index = 0;

    List<int> indexes = new List<int>();



    for (int i = 0; i <= dictionary.Count - words.Length; i++)
    {
        int skip = i;
        foreach (var item in dictionary)
        {
            if (skip != 0)
            {
                skip--;
                continue;
            }

            if (index < words.Length)
            {
                lists.Add(item.Value);
                if(lists.Count == 1)
                {
                    key = item.Key;
                }
            }
            else { break; }
            index++;

            //Оптимизировать проверку
            if (key + sumWords - 1 > s.Length)
            {
                lists.Add(" ");
                break;
            }
        }
        index = 0;

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
            indexes.Add(key);
        }
        lists.Clear();
    }

    return indexes;
}


static Dictionary<int, string> GetArrayOfWords(int wordLength, string mainLIne, string[] words)
{
    Dictionary<int, string> result = new Dictionary<int, string>();
    char[] chars = new char[wordLength];

    for (int i = 0; i <= mainLIne.Length - wordLength; i++)
    {   
        for (int j = 0,k = i; j < wordLength; j++,k++)
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
                result.Add(i,string.Concat(chars));
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