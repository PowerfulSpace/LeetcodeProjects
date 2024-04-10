


int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    long temp2 = 0;
    while (x != 0)
    {
        int digit = x % 10;
        temp2 = temp2 * 10 + digit;
        if (temp2 > int.MaxValue || temp2 < int.MinValue)
        {
            return 0;
        }
        x /= 10;
    }
    return (int)temp2;
}



