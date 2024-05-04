

int divident1 = 10;
int divisor1 = 3;

int divident2 = 7;
int divisor2 = -3;

int divident3 = -2147483648;
int divisor3 = -1;

Console.WriteLine(Divide(divident1, divisor1));
Console.WriteLine(Divide(divident2, divisor2));
Console.WriteLine(Divide(divident3, divisor3));

Console.ReadLine();


static int Divide(int dividend, int divisor)
{
    if(divisor == 0) {  return dividend; }
    return (dividend == int.MinValue && divisor == -1) ? int.MaxValue : (dividend / divisor);
}
