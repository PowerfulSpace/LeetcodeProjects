

using System.Linq;
using System.Text;

string input1 = "III";
string input2 = "LVIII";
string input3 = "MCMXCIV";
string input4 = "MCMXCV";
string input5 = "D";


Console.WriteLine(RomanToInt(input1));
Console.WriteLine(RomanToInt(input2));
Console.WriteLine(RomanToInt(input3));
Console.WriteLine(RomanToInt(input4));
Console.WriteLine(RomanToInt(input5));


Console.ReadLine();





static int RomanToInt(string s)
{
    Dictionary<string, int> nums = new Dictionary<string, int>()
    {
     {"I",1},
     {"IV" , 4},
     {"V" , 5},
     {"IX" , 9},
     {"X" , 10},
     {"XL" , 40},
     {"L" , 50},
     {"XC" , 100},
     {"C" , 100},
     {"CD" , 400},
     {"D" , 500},
     {"CM" , 900},
     { "M", 1000 }
    };

    if(s.Length == 1)
    {
        return nums[s[0].ToString()];
    }

    int curent = 0;
    int next = 0;
    curent = nums[s[0].ToString()];

    int result = 0;

    for (int i = 1; i < s.Length; i++)
    {
        next = nums[s[i].ToString()];

        if (curent < next)
        {
            result += next - curent;

            i++;
            if (i < s.Length - 1)
            {
                curent = nums[s[i].ToString()];
            }
            if (i == s.Length - 1)
            {
                result += nums[s[i].ToString()];
            }

                continue;
        }
        else
        {
            result += curent;

            if (i == s.Length - 1)
            {
                result += next;
            }
        }


        curent = next;
    }
    
    
    return result;
}