ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ReverseKGroup(l1, 3);

Console.ReadLine();


static ListNode ReverseKGroup(ListNode head, int k)
{
    if (k == 1 || head?.next == null) return head;

    ListNode dummy = new();

    dummy.next = head;
    ListNode previous = dummy;
    ListNode tail = dummy;

    while (true)
    {
        int i = 0;
        while (tail != null && i < k)
        {
            ++i;
            tail = tail.next;
        }

        if (tail == null) break;

        ListNode groupHead = previous.next;
        while (i > 1)
        {
            ListNode temp = groupHead.next;
            groupHead.next = temp.next;
            temp.next = previous.next;
            previous.next = temp;
            --i;
        }

        previous = groupHead;
        tail = groupHead;
    }

    return dummy.next;
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
