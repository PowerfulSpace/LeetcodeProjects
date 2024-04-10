

using System.Text;

int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    bool negative = false;

    if (x < 0)
        negative = true;

    string num = x.ToString();


    var numReverse = num.Reverse();
    StringBuilder sb = new StringBuilder();

    foreach (var item in numReverse)
    {
        sb.Append(item);
    }

    if (negative == true)
    {
        sb.Remove(sb.Length - 1, 1);
    }
   
    long result = long.Parse(sb.ToString());

    if(result < int.MaxValue)
    {
        if (negative == true)
        {
            result -= (result * 2);
        }

        return (int)result;
    }
    else
    {
        return 0;
    }
}



