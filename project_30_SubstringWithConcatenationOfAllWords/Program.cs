
using System;
using System.Text;

string str1 = "barfoothefoobarman";
string[] words1 = { "foo", "bar" };

string str2 = "wordgoodgoodgoodbestword";
string[] words2 = { "word", "good", "best", "word" };

string str3 = "barfoofoobarthefoobarman";
string[] words3 = { "bar", "foo", "the" };

string str4 = "wordgoodgoodgoodbestword";
string[] words4 = { "word", "good", "best", "good" };

//FindSubstring(str1, words1);
//FindSubstring(str2, words2);
//FindSubstring(str3, words3);
FindSubstring(str4, words4);


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
	if(words.Length < 1 || words[0].Length > s.Length || s.Length < words.Length * words[0].Length) { return new List<int>(); }

    StringBuilder str = new StringBuilder(s);
    int wordLength = words[0].Length;

    string[] array = new string[s.Length / wordLength];

    GetArrayOfWords(array, str, wordLength);

    List<string> lists = new List<string>();
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


static void GetArrayOfWords(string[] array,StringBuilder str, int wordLength)
{
    for (int i = 0; str.Length != 0; i++)
    {
        char[] chars = new char[wordLength];
        for (int j = 0; j < wordLength; j++)
        {
            chars[j] = str[j];
        }
        array[i] = string.Concat(chars);

        str.Remove(0, wordLength);
    }
}