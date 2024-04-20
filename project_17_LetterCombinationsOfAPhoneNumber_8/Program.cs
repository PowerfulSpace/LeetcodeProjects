


using System.Text;

string digits = "23";
string digits2 = "2";
string digits3 = "234";

//LetterCombinations(digits);
//LetterCombinations(digits2);
LetterCombinations(digits3);



Console.ReadLine();



IList<string> LetterCombinations(string digits)
{

    Dictionary<int, char[]> map = new Dictionary<int, char[]>
    {
        {2, new []{'a', 'b', 'c'}},
        {3, new []{'d', 'e', 'f'}},
        {4, new []{'g', 'h', 'i'}},
        {5, new []{'j', 'k', 'l'}},
        {6, new []{'m', 'n', 'o'}},
        {7, new []{'p', 'q', 'r', 's'}},
        {8, new []{'t', 'u', 'v'}},
        {9, new []{'w', 'x', 'y', 'z'}}
    };

    List<StringBuilder> result = new List<StringBuilder>();

    for (int i = 0; i < digits.Length; i++)
    {
        if (result.Count == 0)
            foreach (var ch in map[int.Parse(digits[i].ToString())])
            {
                result.Add(new StringBuilder(ch.ToString()));
            }
        else
        {
            List<StringBuilder> newList = new List<StringBuilder>();
            foreach (var item in result)
            {
                foreach (var ch in map[int.Parse(digits[i].ToString())])
                {
                    newList.Add(new StringBuilder(item.ToString()).Append(ch));
                }
            }

            result = newList;
        }
    }

    return result.Select(s => s.ToString()).ToList();

}

