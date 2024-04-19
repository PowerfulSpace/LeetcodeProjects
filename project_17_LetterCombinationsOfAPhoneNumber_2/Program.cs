
Dictionary<string, List<string>> digitLetter = new Dictionary<string, List<string>>()
{
    ["2"] = new List<string> { "a", "b", "c" },
    ["3"] = new List<string> { "d", "e", "f" },
    ["4"] = new List<string> { "g", "h", "i" },
    ["5"] = new List<string> { "j", "k", "l" },
    ["6"] = new List<string> { "m", "n", "o" },
    ["7"] = new List<string> { "p", "q", "r", "s" },
    ["8"] = new List<string> { "t", "u", "v" },
    ["9"] = new List<string> { "w", "x", "y", "z" },
};


string digits = "23";
string digits2 = "2";
string digits3 = "234";

//LetterCombinations(digits);
//LetterCombinations(digits2);
LetterCombinations(digits3);



Console.ReadLine();



IList<string> LetterCombinations(string digits)
{

    if (digits.Length == 0) return new List<string>();

    var output = new List<string>();

    output = CreateCombinations(output, "", digits);

    return output;
}

List<string> CreateCombinations(List<string> combinations, string currentCombination, string remainingDigits)
{
    foreach (string letter in digitLetter[remainingDigits.Substring(0, 1)])
    {
        var tempCombination = currentCombination + letter;

        if (remainingDigits.Length > 1)
        {
            combinations = CreateCombinations(combinations, tempCombination, remainingDigits.Substring(1));
        }
        else
        {
            combinations.Add(tempCombination);
        }
    }

    return combinations;
}

