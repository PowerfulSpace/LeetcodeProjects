



ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ReverseKGroup(l1, 3);

Console.ReadLine();


static ListNode ReverseKGroup(ListNode head, int k)
{

    ListNode headResult = new ListNode();
    ListNode tailResult = headResult;

    List<int> kit = new List<int>();

    while(head != null)
    {
        kit.Add(head.val);

        if(kit.Count == k)
        {
            while(kit.Count != 0)
            {
                tailResult.next = new ListNode(kit.Last());
                tailResult = tailResult.next;
                kit.RemoveAt(kit.Count - 1);
            }           
        }

        head = head.next;
    }

    while (kit.Count != 0)
    {
        tailResult.next = new ListNode(kit.First());
        tailResult = tailResult.next;
        kit.RemoveAt(0);
    }



    return headResult.next;
}





public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
