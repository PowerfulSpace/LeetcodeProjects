
using System;

ListNode l1 = new ListNode(1, new ListNode(4, new ListNode(5)));
ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode l3 = new ListNode(2, new ListNode(6));
ListNode l4 = new ListNode(1, new ListNode(4, new ListNode(5)));
ListNode l5 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode l6 = new ListNode(2, new ListNode(6));
ListNode l7 = new ListNode(2, new ListNode(6));
ListNode l8 = new ListNode(2, new ListNode(6));
ListNode l9 = new ListNode(2, new ListNode(6));
ListNode l10 = new ListNode(2, new ListNode(6));
ListNode l11 = new ListNode(2, new ListNode(6));
ListNode l12 = new ListNode(2, new ListNode(6));
ListNode l13 = new ListNode(2, new ListNode(6));
ListNode l14 = new ListNode(2, new ListNode(6));
ListNode l15 = new ListNode(2, new ListNode(6));
ListNode l16 = new ListNode(2, new ListNode(6));
ListNode l17 = new ListNode(2, new ListNode(6));


ListNode[] lists = new ListNode[] { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17 };

MergeKLists(lists);


Console.ReadLine();



static ListNode MergeKLists(ListNode[] lists)
{
    if (lists == null || lists.Length == 0)
        return null;

    if (lists.Length == 1)
        return lists[0];

    var skip = 1;
    var n = lists.Length;

    while (skip < n)
    {
        for (int i = 0; i < n - skip; i += skip * 2)
        {
            lists[i] = merge(lists[i], lists[i + skip]);
        }
        skip *= 2;
    }

    return lists[0];
}

static ListNode merge(ListNode list1, ListNode list2)
{
    var node = new ListNode();
    var curr = node;
    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            curr.next = list1;
            list1 = list1.next;

        }
        else
        {
            curr.next = list2;
            list2 = list2.next;
        }

        curr = curr.next;
    }

    if (list1 != null)
        curr.next = list1;
    if (list2 != null)
        curr.next = list2;

    return node.next;
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
