

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
    int result = 0;
    int previous = 0;
    Dictionary<char, int> roman = new Dictionary<char, int>();

    roman.Add('I', 1);
    roman.Add('V', 5);
    roman.Add('X', 10);
    roman.Add('L', 50);
    roman.Add('C', 100);
    roman.Add('D', 500);
    roman.Add('M', 1000);

    for (int i = s.Length - 1; i >= 0; --i)
    {
        if (previous <= roman[s[i]])
        {
            result += roman[s[i]];
        }
        else if (previous > roman[s[i]])
        {
            result -= roman[s[i]];
        }
        previous = roman[s[i]];
    }

    return result;
}