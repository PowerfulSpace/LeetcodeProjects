


string digits = "23";
string digits2 = "2";
string digits3 = "234";

//LetterCombinations(digits);
//LetterCombinations(digits2);
LetterCombinations(digits3);



Console.ReadLine();



IList<string> LetterCombinations(string digits)
{
    if (string.Equals(digits.Trim(), ""))
    {
        return new List<string>();
    }

    var numberAsStringToLettersDictionary = new Dictionary<char, List<string>>
        {
            { '2', new List<string> { "a", "b", "c" } },
            { '3', new List<string> { "d", "e", "f" } },
            { '4', new List<string> { "g", "h", "i" } },
            { '5', new List<string> { "j", "k", "l" } },
            { '6', new List<string> { "m", "n", "o" } },
            { '7', new List<string> { "p", "q", "r", "s" } },
            { '8', new List<string> { "t", "u", "v"} },
            { '9', new List<string> { "w", "x", "y", "z" } }
        };
    var listOne = digits.Length >= 1
        ? numberAsStringToLettersDictionary[digits[0]]
        : new List<string> { "" };
    var listTwo = digits.Length >= 2
        ? numberAsStringToLettersDictionary[digits[1]]
        : new List<string> { "" };
    var listThree = digits.Length >= 3
        ? numberAsStringToLettersDictionary[digits[2]]
        : new List<string> { "" };
    var listFour = digits.Length >= 4
        ? numberAsStringToLettersDictionary[digits[3]]
        : new List<string> { "" };
    var results = new List<string>();
    foreach (var characterOne in listOne)
    {
        foreach (var characterTwo in listTwo)
        {
            foreach (var characterThree in listThree)
            {
                foreach (var characterFour in listFour)
                {
                    results.Add($"{characterOne}{characterTwo}{characterThree}{characterFour}");
                }
            }
        }
    }
    return results;

}
