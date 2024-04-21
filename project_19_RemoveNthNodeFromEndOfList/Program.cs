



LinkedList<int> input = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
LinkedList<int> input2 = new LinkedList<int>(new int[] { 1 });
LinkedList<int> input3 = new LinkedList<int>(new int[] { 1, 2 });


Console.WriteLine(RemoveNthFromEnd(input.Last, 2));



Console.ReadLine();


static LinkedListNode<int> RemoveNthFromEnd(LinkedListNode<int> head, int n)
{
    if(head.Previous == null && n == 1) { return head; }

    LinkedList<int> result = new LinkedList<int>();
    Stack<int> save = new Stack<int>();

    int count = 1;


    while(head != null)
    {

        if(count == n)
        {
        }
        else
        {
            save.Push(head.Value);       
        }
        head = head.Previous;
        count++;
    }

    foreach (var item in save)
    {
        result.AddLast(item);
    }


    return result.First;
}