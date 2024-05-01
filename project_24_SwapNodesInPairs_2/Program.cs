



ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
ListNode l2 = new ListNode(1);
ListNode l3 = null;

SwapPairs(l1);
SwapPairs(l2);
SwapPairs(l3);

Console.ReadLine();


static ListNode SwapPairs(ListNode head)
{
    if (head == null || head.next == null) return head;

    var next = head.next;
    head.next = SwapPairs(next.next);
    next.next = head;

    return next;
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
