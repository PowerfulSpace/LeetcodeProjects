
using System;

ListNode l1 = new ListNode(1, new ListNode(4, new ListNode(5)));
ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode l3 = new ListNode(2, new ListNode(6));

ListNode[] lists = new ListNode[] { l1, l2, l3 };

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
