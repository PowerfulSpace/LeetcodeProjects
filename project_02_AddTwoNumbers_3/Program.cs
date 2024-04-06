using System.Text;

//Example 1:
List<int> array1 = new List<int>() { 2, 4, 3 };
List<int> array2 = new List<int>() { 5, 6, 4 };

LinkedList<int> l1 = new LinkedList<int>(array1);
LinkedList<int> l2 = new LinkedList<int>(array2);

Print(l1.First);
Print(l2.First);


LinkedListNode<int> result = AddTwoNumbers(l1.First, l2.First);

Print(result);


Console.ReadLine();

static LinkedListNode<int> AddTwoNumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
{
    int sum = l1.Value + l2.Value;
    LinkedListNode<int> result = new LinkedListNode<int>(sum % 10);
    LinkedListNode<int> current = result;
    l1 = l1?.Next;
    l2 = l2?.Next;
    int firstVal;
    int secondVal;
    while (l1 != null || l2 != null || sum >= 10)
    {
        firstVal = l1 != null ? l1.Value : 0;
        secondVal = l2 != null ? l2.Value : 0;
        sum = sum < 10 ? firstVal + secondVal : firstVal + secondVal + 1;

        current.Next = new LinkedListNode<int>(sum % 10);
        current = current.Next;

        l1 = l1?.Next;
        l2 = l2?.Next;
    }
    return result;
}



static void Print(LinkedListNode<int> link)
{
    while (link != null)
    {
        Console.Write(link.Value + " ");
        link = link.Next;
    }
    Console.WriteLine();
}