


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

    List<string> result;
    List<string> temporary;

    Dictionary<char, char[]> dic = new()
    {
        { '2', new[] { 'a', 'b', 'c' }},
        { '3', new[] { 'd', 'e', 'f' }},
        { '4', new[] { 'g', 'h', 'i' }},
        { '5', new[] { 'j', 'k', 'l' }},
        { '6', new[] { 'm', 'n', 'o' }},
        { '7', new[] { 'p', 'q', 'r', 's' }},
        { '8', new[] { 't', 'u', 'v' }},
        { '9', new[] { 'w', 'x', 'y', 'z' }},
    };

    result = new List<string>() { "" };
    foreach (var d in digits)
    {
        temporary = new List<string>();

        foreach (var s in result)
        {
            foreach (var c in dic[d])
            {
                temporary.Add(s + c);
            }              
        }
            
        result = temporary;
    }

    GC.Collect();
    return result;
}
