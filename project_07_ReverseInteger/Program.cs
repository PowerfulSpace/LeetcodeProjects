

using System.Text;

int input1 = 123;
int input2 = -123;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));

Console.ReadLine();


static int Reverse(int x)
{
    bool negative = false;

    if (x < 0)
        negative = true;

    string digit = x.ToString();


    var b = digit.Reverse();
    StringBuilder sb = new StringBuilder();

    foreach (var item in b)
    {
        sb.Append(item);
    }

    if (negative == true)
    {
        sb.Remove(sb.Length - 1, 1);
    }
   

    int result = int.Parse(sb.ToString());

    if (negative == true)
    {
        result -= (result * 2);
    }

    return result;
}



