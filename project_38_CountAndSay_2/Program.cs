


using System.Text;

int input1 = 1;
int input2 = 2;
int input3 = 3;
int input4 = 4;
int input5 = 5;
int input6 = 6;

//Console.WriteLine(CountAndSay(input1));
//Console.WriteLine(CountAndSay(input2));
//Console.WriteLine(CountAndSay(input3));
//Console.WriteLine(CountAndSay(input4));
//Console.WriteLine(CountAndSay(input5));
Console.WriteLine(CountAndSay(input6));




Console.ReadLine();




string CountAndSay(int n)
{
    StringBuilder strCurrent = new StringBuilder();
    StringBuilder resul = Compression(new StringBuilder("1"),n, new StringBuilder());

    return resul.ToString();
}

StringBuilder Compression(StringBuilder str,int n, StringBuilder strCurrent)
{
    if(n == 1) { return str; }

    strCurrent.Clear();
    n--;

    int count = 1;
    char digit = str[0];
    for (int i = 1; i < str.Length; i++)
    {
        if (digit == str[i]) { count++; }
        else
        {
            strCurrent.Append(count).Append(digit);
            digit = str[i];
            count = 1;

            if(i + 1 == str.Length)
            {
                strCurrent.Append(count).Append(str[i]);
            }
        }
    }
    if(count > 1) { strCurrent.Append(count).Append(digit); }
    if(str.Length == 1) { strCurrent.Append(count).Append(digit); }

    str.Clear();
    str.Append(strCurrent);

    Compression(str, n, strCurrent);

    return str;
}