
using System;
using System.Text;

string str1 = "barfoothefoobarman";
string[] words1 = { "foo", "bar" };

string str2 = "wordgoodgoodgoodbestword";
string[] words2 = { "word", "good", "best", "word" };

string str3 = "barfoofoobarthefoobarman";
string[] words3 = { "bar", "foo", "the" };

string str4 = "";
string[] words4 = { };

//FindSubstring(str1, words1);
FindSubstring(str2, words2);
//FindSubstring(str3, words3);
//FindSubstring(str4, words4);


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
	if(words.Length < 1 || words[0].Length > s.Length || s.Length < words.Length * words[0].Length) { return new List<int>(); }

    var a = words.Length;
    var b = words[0].Length;

    StringBuilder str = new StringBuilder(s);
    int wordLength = words[0].Length;
    int compoudWordLength = wordLength * words.Length;
    int index = 0;

    List<int> blockIndexes = new List<int>();

    for (int i = 0; i < s.Length && s.Length > i + compoudWordLength; i++)
    {
        
        str.Length = compoudWordLength;

        for (int j = 0; j < words.Length; j++)
        {
            if (str.ToString().Contains(words[i]))
            {

            }
        }

        str.Clear();
        str.Append(s);
        str.Remove(i, 1);

        //if (!s.Contains(words[i])) { return new List<int>(); }
    }

    str.Clear();
    str.Append(s);

    List<int> indexs = new List<int>();





    return indexs;
}


