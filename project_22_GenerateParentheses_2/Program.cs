

int num1 = 1;
int num2 = 2;
int num3 = 3;
int num4 = 4;

//Console.WriteLine(GenerateParenthesis(num1));
//Console.WriteLine(GenerateParenthesis(num2));
Console.WriteLine(GenerateParenthesis(num3));
//Console.WriteLine(GenerateParenthesis(num4));


Console.ReadLine();


IList<string> GenerateParenthesis(int n)
{
    var str = new List<string>();
     Gen(str, "", n, 0);

    return str;
}

static void Gen(IList<string> all, string currentStr, int toOpen, int opened)
{
    if (opened < 0)
    {
        return;
    }
    if (toOpen == 0)
    {
        if (opened > 0)
        {
            currentStr += new string(')', opened);
            opened = 0;
        }
    }
    else
    {
        Gen(all, currentStr + "(", toOpen - 1, opened + 1);
        Gen(all, currentStr + ")", toOpen, opened - 1);
    }

    if (toOpen == 0 && opened == 0)
        all.Add(currentStr);
}

