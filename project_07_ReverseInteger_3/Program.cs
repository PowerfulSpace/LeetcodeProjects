


int input1 = 123;
int input2 = -123;
int input3 = 1534236469;

Console.WriteLine(Reverse(input1));
Console.WriteLine(Reverse(input2));
Console.WriteLine(Reverse(input3));

Console.ReadLine();

static int Reverse(int x)
{
    string strReverse = new string(x.ToString().Trim('-').Reverse().ToArray());
    bool tryInt32 = int.TryParse(strReverse, out int intVal);
    return tryInt32 ? x.ToString().Contains("-") ? intVal * -1 : intVal : 0;
}



