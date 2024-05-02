ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ReverseKGroup(l1, 3);

Console.ReadLine();


static ListNode ReverseKGroup(ListNode head, int k)
{
    ListNode curr = head;
    int count = 0;
    while (curr != null && count < k)
    {
        curr = curr.next;
        count++;
    }
    if (count == k)
    {
        ListNode newHead = ReverseKGroup(curr, k);
        var result = Reverse(head, k, newHead);
        return result;
    }
    return head;
}

static ListNode Reverse(ListNode head, int k, ListNode newHead)
{
    ListNode curr = head;
    ListNode prev = newHead;

    for (int i = 0; i < k; i++)
    {
        ListNode nextTemp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = nextTemp;
    }
    return prev;
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
