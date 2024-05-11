

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
    int k = words[0].Length;
    int len = k * words.Length;

    Dictionary<string, int> count = new();
    foreach (var w in words)
        if (!count.TryAdd(w, 1))
            count[w]++;

    List<int> lst = new();

    for (int i = 0; i < s.Length - len + 1; i++)
    {
        string word = s[i..(i + k)];

        if (!count.ContainsKey(word))
            continue;

        int start = i;
        Dictionary<string, int> count_ = new(count);
        count_[word]--;

        for (int j = i + k; j < i + len; j += k)
        {
            word = s[j..(j + k)];

            if (!count.ContainsKey(word) || count_[word] <= 0)
                break;

            count_[word]--;
        }

        if (count_.Values.Sum() == 0)
            lst.Add(start);
    }

    return lst;
}

