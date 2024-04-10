


int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    int reverse = 0;
    while (x != 0)
    {
        if (reverse > Int32.MaxValue / 10 || reverse < Int32.MinValue / 10) return 0;
        int digit = x % 10;
        x /= 10;
        reverse = reverse * 10 + digit % 10;
    }
    return reverse;
}



