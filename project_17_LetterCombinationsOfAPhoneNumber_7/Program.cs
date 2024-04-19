


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
    if (digits.Length == 0) return new List<string>();

    Dictionary<char, char[]> map = new(){
            { '2', [ 'a','b','c' ] },
            { '3', [ 'd','e','f' ] },
            { '4', [ 'g','h','i' ] },
            { '5', [ 'j','k','l' ] },
            { '6', [ 'm','n','o' ] },
            { '7', [ 'p','q','r','s' ] },
            { '8', [ 't','u','v' ] },
            { '9', [ 'w','x','y','z' ] }
        };

    List<string> results = new();

    Action<string, int> fn = null;
    fn = (string Path, int index) => {
        if (index == digits.Length)
        {
            results.Add(Path);
            return;
        }

        foreach (char letter in map[digits[index]])
        {
            fn(Path + letter, index + 1);
        }
    };
    fn("", 0);

    return results;

}

