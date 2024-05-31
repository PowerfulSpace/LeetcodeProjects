


using System.Text;

int input1 = 1;
int input2 = 2;
int input3 = 3;
int input4 = 4;
int input5 = 5;

Console.WriteLine(CountAndSay(input1));
Console.WriteLine(CountAndSay(input2));
Console.WriteLine(CountAndSay(input3));
Console.WriteLine(CountAndSay(input4));
Console.WriteLine(CountAndSay(input5));




Console.ReadLine();

StringBuilder resultCompression;
string CountAndSay(int n)
{
    if(n == 1) { return "1"; }

    resultCompression = new StringBuilder();

    StringBuilder result = new StringBuilder("1");

    for (int i = 1; i < n; i++)
	{
        Compression(result);
        result.Clear();
        result.Append(resultCompression);
    }

    return result.ToString();
}
void Compression(StringBuilder str)
{
    resultCompression.Clear();
    int count = 1;
    char digit = str[0];

    for (int i = 1; i < str.Length; i++)
    {
        if(digit == str[i])
        {
            count++;
        }
        else
        {
            resultCompression.Append(count).Append(digit);

            count = 1;
            digit = str[i];

            if (i + 1 == str.Length)
            {
                resultCompression.Append(count).Append(digit);
            }
        }
    }
    if(count > 1)
    {
        resultCompression.Append(count).Append(digit);
    }
    if (str.Length == 1)
    {
        resultCompression.Append(count).Append(digit);
    }
}