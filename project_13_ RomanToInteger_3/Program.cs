

string input1 = "III";
string input2 = "LVIII";
string input3 = "MCMXCIV";
string input4 = "MCMXCV";
string input5 = "D";


//Console.WriteLine(RomanToInt(input1));
//Console.WriteLine(RomanToInt(input2));
Console.WriteLine(RomanToInt(input3));
Console.WriteLine(RomanToInt(input4));
Console.WriteLine(RomanToInt(input5));


Console.ReadLine();





static int RomanToInt(string s)
{
    Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    int total = 0;
    int prevValue = 0;

    foreach (char c in s)
    {
        int value = romanMap[c];
        if (value > prevValue)
        {
            total += value - (2 * prevValue); // Subtract the value of previous character twice
        }
        else
        {
            total += value;
        }
        prevValue = value;
    }

    return total;
}