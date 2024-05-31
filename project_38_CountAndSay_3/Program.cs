


using System.Text;

int input1 = 1;
int input2 = 2;
int input3 = 3;
int input4 = 4;
int input5 = 5;
int input6 = 6;

Console.WriteLine(CountAndSay(input1));
Console.WriteLine(CountAndSay(input2));
Console.WriteLine(CountAndSay(input3));
Console.WriteLine(CountAndSay(input4));
Console.WriteLine(CountAndSay(input5));
Console.WriteLine(CountAndSay(input6));




Console.ReadLine();




string CountAndSay(int n)
{
    if (n == 1)
    {
        return "1";
    }
    var prev = CountAndSay(n - 1);
    var final = new StringBuilder();

    var i = 0;
    var num = 0;
    var cur_char = prev[0];
    while (i < prev.Length)
    {
        if (prev[i] == cur_char)
        {
            num++;
        }
        else
        {
            final.Append(num.ToString());
            final.Append(cur_char);
            num = 1;
            cur_char = prev[i];
        }
        i++;
    }
    final.Append(num.ToString());
    final.Append(cur_char);

    return final.ToString();
}
