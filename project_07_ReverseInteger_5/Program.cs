


int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    List<char> digits = x.ToString().ToList();
    digits.Reverse();
    bool negative = false;
    foreach (char a in digits)
    {
        if (a == '-')
        {
            negative = true;

        }
    }
    digits = digits.FindAll(x => x != '-');
    Console.WriteLine(string.Join("", digits.ToArray()));

    int value = 0;
    try
    {
        value = negative ? int.Parse(string.Join("", digits.ToArray())) * -1 : int.Parse(string.Join("", digits.ToArray()));
    }
    catch
    {

    }
    return value >= int.MaxValue || value <= int.MinValue ? 0 : value;
}



