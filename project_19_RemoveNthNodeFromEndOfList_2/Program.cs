



LinkedList<int> input = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
LinkedList<int> input2 = new LinkedList<int>(new int[] { 1 });
LinkedList<int> input3 = new LinkedList<int>(new int[] { 1, 2 });


Console.WriteLine(RemoveNthFromEnd(input.First, 2));



Console.ReadLine();


static LinkedListNode<int> RemoveNthFromEnd(LinkedListNode<int> head, int n)
{
    if (head.Next == null && n == 1) { return head; }

    LinkedList<int> result = new LinkedList<int>();
    Stack<int> save = new Stack<int>();
    int count = 0;

    while (head != null)
    {

        result.AddLast(head.Value);
        head = head.Next;
        

        if (head == null)
        {
            while(n > 0)
            {
                if(n - 1 > 0)
                {
                    save.Push(result.Last.Value);
                }    
                result.RemoveLast();
                n--;
            }
            foreach (var item in save)
            {
                result.AddLast(item);
            }
        }
    }

    return result.First;
}