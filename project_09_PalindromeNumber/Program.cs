﻿

int input1 = 121;
int input2 = -121;
int input3 = 10;

Console.WriteLine(IsPalindrome(input1));
Console.WriteLine(IsPalindrome(input2));
Console.WriteLine(IsPalindrome(input3));

Console.ReadLine();




static bool IsPalindrome(int x)
{
    if (x < 0) return false;
    string digits = x.ToString();
    int end = digits.Length - 1;

    for (int i = 0; i < digits.Length / 2; i++)
    {
        if (digits[i] != digits[end])
        {
            return false;
        }
        end--;
    }

    return true;
}

