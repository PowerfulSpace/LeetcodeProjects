using System.Text;

//Example 1:
//List<double> array1 = new List<double>() { 2, 4, 3 };
//List<double> array2 = new List<double>() { 5, 6, 4 };

//Example 2:
//List<double> array1 = new List<double>(0);
//List<double> array2 = new List<double>(0);

//Example 3:
List<double> array1 = new List<double>() { 9,9,9,9,9,9,9};
List<double> array2 = new List<double>() { 9, 9, 9, 9 };

LinkedList<double> l1 = new LinkedList<double>(array1);
LinkedList<double> l2 = new LinkedList<double>(array2);

Print(l1.First);
Print(l2.First);


LinkedListNode<double> result = AddTwoNumbers(l1.First, l2.First);

Print(result);


Console.ReadLine();

static LinkedListNode<double> AddTwoNumbers(LinkedListNode<double> l1, LinkedListNode<double> l2)
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

    return result.First;
}
 
static int TransformationInReverseNums(LinkedListNode<double> link)
{
    StringBuilder stringBuilder = new StringBuilder();

    Stack<double> stack = new Stack<double>();

    while (link != null)
    {
        stack.Push(link.Value);
        link = link.Next;
    }


    foreach (var item in stack)
    {
        stringBuilder.Append(item);
    }

    if(stack.Count > 0)
    {
        return int.Parse(stringBuilder.ToString());
    }
    else
    {
        return 0;
    }
   
}


static void Print(LinkedListNode<double> link)
{
    while (link != null)
    {
        Console.Write(link.Value + " ");
        link = link.Next;
    }
    Console.WriteLine();
}