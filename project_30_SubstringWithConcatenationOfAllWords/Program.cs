
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
	if(words.Length < 1 || words[0].Length > s.Length) { return new List<int>(); }

    StringBuilder str = new StringBuilder(s);
    int wordLength = words[0].Length;
    int index = 0;

    List<int> blockIndexes = new List<int>();

    string checkString = s;

    for (int i = 0; i < words.Length; i++)
    {
        if (!checkString.Contains(words[i])) { return new List<int>(); }

        index = checkString.IndexOf(words[i]);

        //Продумать как правильно проверять. не плодя при этом лишнии обьекты
        //if (blockIndexes.Contains(index))
        //{
        //    checkString = str.ToString();
        //    checkString = checkString.Remove(index, wordLength);
        //    checkString = checkString.Insert(index, new string('_', wordLength));
        //}


        blockIndexes.Add(index);
        str.Remove(index, wordLength);
        str.Insert(index, "_", wordLength);
    }

    str.Clear();
    str.Append(s);

    List<int> indexs = new List<int>();


    for (int i = 0; i < s.Length; i++)
    {

    }



    return indexs;
}


