

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
    if (x / 10 == 0) return true;

    var tmp = x;
    var y = tmp % 10;
    while (tmp / 10 != 0)
    {
        y = (y * 10) + (tmp /= 10) % 10;
    }

    return y == x ? true : false;
}

