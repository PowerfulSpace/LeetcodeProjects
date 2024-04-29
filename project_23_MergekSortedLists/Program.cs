
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

    for (ListNode node = l1; node != null; node = node.next)
    {
        if (l2 != null)
        {
            node.val += l2.val;
            l2 = l2.next;

            if (l2 != null && node.next == null)
            {
                node.next = new ListNode();
            }
        }

        if (node.val >= 10)
        {
            node.val -= 10;

            if (node.next == null)
            {
                node.next = new ListNode();
            }
            node.next.val += 1;
        }
    }
    return l1;
}



public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
