
string str1 = "barfoothefoobarman";
string[] words1 = { "foo", "bar" };

string str2 = "wordgoodgoodgoodbestword";
string[] words2 = { "word", "good", "best", "word" };

string str3 = "barfoofoobarthefoobarman";
string[] words3 = { "bar", "foo", "the" };

FindSubstring(str1, words1);
FindSubstring(str2, words2);
FindSubstring(str3, words3);


Console.ReadLine();

static IList<int> FindSubstring(string s, string[] words)
{
	List<int> indexs = new List<int>();

	for (int i = 0; i < words.Length; i++)
	{
		if (!s.Contains(words[i])) { return new List<int>(); }

		indexs.Add(s.IndexOf(words[i]));

    }

    return indexs;
}


