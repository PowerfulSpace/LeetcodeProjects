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
    for (LinkedListNode<int> node = l1; node != null; node = node.Next)
    {
        if (l2 != null)
        {
            node.Value += l2.Value;
            l2 = l2.Next;

            if (l2 != null && node.Next == null)
            {
                node.Next = new LinkedListNode<int>();
            }
        }

        if (node.Value >= 10)
        {
            node.Value -= 10;

            if (node.Next == null)
            {
                node.Next = new LinkedListNode<int>();
            }
            node.Next.Value += 1;
        }
    }
    return l1;
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