

using System.Text;

List<int> array1 = new List<int>() { 2, 4, 3 };
List<int> array2 = new List<int>() { 5, 6, 4 };

LinkedList<int> l1 = new LinkedList<int>(array1);
LinkedList<int> l2 = new LinkedList<int>(array2);

Print(l1);
Print(l2);


var result = AddTwoNumbers(l1, l2);




Console.ReadLine();

static LinkedList<double> AddTwoNumbers(LinkedList<int> l1, LinkedList<int> l2)
{
    int numL1 = TransformationInReverseNums(l1);
    int numL2 = TransformationInReverseNums(l2);

    int sum = numL1 + numL2;
    var sumArrayChars = sum.ToString().Reverse();

    LinkedList<double> result = new LinkedList<double>();

    foreach (var item in sumArrayChars)
    {
        double digit = char.GetNumericValue(item);
        result.AddLast(digit);
    }

    return result;
}

static int TransformationInReverseNums(LinkedList<int> link)
{
    StringBuilder stringBuilder = new StringBuilder();

    foreach (var item in link.Reverse())
    {
        stringBuilder.Append(item);
    }

    return int.Parse(stringBuilder.ToString());
}


static void Print(LinkedList<int> link)
{
	foreach (var item in link)
	{
        Console.Write(item + " ");
    }
    Console.WriteLine();
}