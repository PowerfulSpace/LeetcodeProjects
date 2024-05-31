


using System.Text;

int input1 = 4;

Console.WriteLine(CountAndSay(input1));




Console.ReadLine();

StringBuilder resultCompression;
string CountAndSay(int n)
{
    //Compression(new StringBuilder("11122311556633333"));

    if(n == 1) { return "1"; }

    resultCompression = new StringBuilder();

    StringBuilder result = new StringBuilder("1");

    for (int i = 0; i < n; i++)
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