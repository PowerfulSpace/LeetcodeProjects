


string digits = "23";
string digits2 = "2";
string digits3 = "234";

//LetterCombinations(digits);
//LetterCombinations(digits2);
LetterCombinations(digits3);



Console.ReadLine();



IList<string> LetterCombinations(string digits)
{
    IList<string> combinations = new List<string>();

    if (string.IsNullOrWhiteSpace(digits))
    {
        return combinations;
    }

    Dictionary<char, string> dictionary = new();
    dictionary.Add('2', "abc");
    dictionary.Add('3', "def");
    dictionary.Add('4', "ghi");
    dictionary.Add('5', "jkl");
    dictionary.Add('6', "mno");
    dictionary.Add('7', "pqrs");
    dictionary.Add('8', "tuv");
    dictionary.Add('9', "wxyz");

    Backtrack(combinations, string.Empty, 0, digits, dictionary);

    return combinations;

}

static void Backtrack(IList<string> combinations, string pattern, int index, string digits, Dictionary<char, string> dictionary)
{
    if (index >= digits.Length)
    {
        combinations.Add(pattern);
        return;
    }
    foreach (char ch in dictionary[digits[index]])
    {
        Backtrack(combinations, pattern + ch, index + 1, digits, dictionary);
    }
}