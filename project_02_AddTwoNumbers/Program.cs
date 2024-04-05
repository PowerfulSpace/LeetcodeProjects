

List<int> array1 = new List<int>() { 2, 4, 3 };
List<int> array2 = new List<int>() { 5, 6, 4 };

LinkedList<int> l1 = new LinkedList<int>(array1);
LinkedList<int> l2 = new LinkedList<int>(array2);

Print(l1);
Print(l2);


AddTwoNumbers(l1, l2);


Console.ReadLine();

static LinkedList<int> AddTwoNumbers(LinkedList<int> l1, LinkedList<int> l2)
{

}

static void Print(LinkedList<int> link)
{
	foreach (var item in link)
	{
        Console.Write(item + " ");
    }
    Console.WriteLine();
}