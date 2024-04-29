
ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

//ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9,
//              new ListNode(9, new ListNode(9, new ListNode(9,
//              new ListNode(9, new ListNode(9, new ListNode(9)))))))));
//ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

AddTwoNumbers(l1, l2);


Console.ReadLine();



static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
{

    if (l1 == null && l2 == null && carry == 0) return null;

    int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
    carry = total / 10;
    return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
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
