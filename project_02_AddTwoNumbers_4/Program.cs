
ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

//ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9,
//              new ListNode(9, new ListNode(9, new ListNode(9,
//              new ListNode(9, new ListNode(9, new ListNode(9)))))))));
//ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

AddTwoNumbers(l1, l2);


Console.ReadLine();



static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{

    int iCarray = 0;
    ListNode result = new ListNode();
    ListNode current = result;

    while (l1 != null || l2 != null || iCarray > 0)
    {
        int iSum = (l1?.val ?? 0) + (l2?.val ?? 0) + iCarray;
        iCarray = iSum / 10;

        current.next = new ListNode(iSum % 10);
        current = current.next;

        l1 = l1?.next;
        l2 = l2?.next;
    }

    if (iCarray != 0)
        current.next = new ListNode(iCarray);

    return result.next;
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
