


int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    int result = 0;
    while (x != 0)
    {
        int v = x % 10;
        x = x / 10;
        if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && v > 7)) return 0;
        if (result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 && v < -8)) return 0;
        result = result * 10 + v;
    }
    return result;
}



