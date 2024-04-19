


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
    List<string> combinations = new List<string>();

    foreach (char digit in digits)
    {
        List<string> nextCombos = new List<string>();

        List<char> letters = digitLetters(digit);
        if (combinations.Count == 0)
        {
            foreach (char letter in letters)
            {
                nextCombos.Add(letter.ToString());
            }
        }
        else
        {
            foreach (string previousCombo in combinations)
            {
                foreach (char letter in letters)
                {
                    nextCombos.Add(previousCombo + letter);
                }
            }
        }

        combinations = nextCombos;
    }

    return combinations;

}


static List<char> digitLetters(char c)
{

    List<char> letters = new List<char>();

    if (c == '2')
    {
        letters.Add('a');
        letters.Add('b');
        letters.Add('c');
    }
    else if (c == '3')
    {
        letters.Add('d');
        letters.Add('e');
        letters.Add('f');
    }
    else if (c == '4')
    {
        letters.Add('g');
        letters.Add('h');
        letters.Add('i');
    }
    else if (c == '5')
    {
        letters.Add('j');
        letters.Add('k');
        letters.Add('l');
    }
    else if (c == '6')
    {
        letters.Add('m');
        letters.Add('n');
        letters.Add('o');
    }
    else if (c == '7')
    {
        letters.Add('p');
        letters.Add('q');
        letters.Add('r');
        letters.Add('s');
    }
    else if (c == '8')
    {
        letters.Add('t');
        letters.Add('u');
        letters.Add('v');
    }
    else if (c == '9')
    {
        letters.Add('w');
        letters.Add('x');
        letters.Add('y');
        letters.Add('z');
    }

    return letters;

}