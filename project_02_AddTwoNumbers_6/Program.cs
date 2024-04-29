
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

    var response = new ListNode(l1.val + l2.val);

    var firstNext = GetNext(l1.next);
    firstNext.val += GetRemainder(response);

    if (l1.next == null && l2.next == null && firstNext.val < 1)
    {
        return response;
    }

    response.next = AddTwoNumbers(firstNext, GetNext(l2.next));

    return response;
}

static ListNode GetNext(ListNode listNode)
{
    return listNode != null ? listNode : new ListNode(0);
}

static int GetRemainder(ListNode listNode)
{
    var response = listNode.val / 10;
    listNode.val = listNode.val % 10;

    return response;
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
