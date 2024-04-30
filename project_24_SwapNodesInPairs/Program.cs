



ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
ListNode l2 = new ListNode(1);
ListNode l3 = null;

SwapPairs(l1);
SwapPairs(l2);
SwapPairs(l3);

Console.ReadLine();



static ListNode SwapPairs(ListNode head)
{
    if(head == null) return head;

    ListNode resultHead = new ListNode();
    ListNode resultTail = resultHead;

    Stack<int> reverse = new Stack<int>();

    while(head != null)
    {
        reverse.Push(head.val);

        if(reverse.Count == 2 || head.next == null)
        {
            while(reverse.Count != 0)
            {
                resultTail.next = new ListNode(reverse.Pop());
                resultTail = resultTail.next;
            }
        }

        head = head.next;
    }

    resultHead = resultHead.next;
    return resultHead;
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
