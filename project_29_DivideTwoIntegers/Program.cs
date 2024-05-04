

int divident1 = 10;
int divisor1 = 3;

int divident2 = 7;
int divisor2 = -3;

int divident3 = -2147483648;
int divisor3 = -1;

//Console.WriteLine(Divide(divident1, divisor1));
//Console.WriteLine(Divide(divident2, divisor2));
Console.WriteLine(Divide(divident3, divisor3));

Console.ReadLine();


static int Divide(int dividend, int divisor)
{

    if (divisor == 0 && dividend < int.MaxValue && dividend > int.MinValue) { return dividend; }

    if (dividend >= int.MaxValue) { return int.MaxValue / divisor; }
    if(dividend <= int.MinValue)
    {
        if(divisor < 0)
        {
            if(divisor == -1)
            {
                return int.MaxValue;
            }
        }
        else
        {
            return int.MinValue / divisor;
        }
    }

    return dividend / divisor;
}
