
using System;

ListNode l1 = new ListNode(1, new ListNode(4, new ListNode(5)));
ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
ListNode l3 = new ListNode(2, new ListNode(6));

ListNode[] lists = new ListNode[] { l1, l2, l3 };

MergeKLists(lists);


Console.ReadLine();



static ListNode MergeKLists(ListNode[] lists)
{
    List<int> kit = new List<int>();

    foreach (ListNode l in lists)
    {
        if(kit.Count == 0)
        {
            var element = l;
            while(element != null)
            {
                kit.Add(element.val);
                element = element.next;
            }
            continue;
        }

        var item = l;
        while (item != null)
        {
            for (int i = 0; i < kit.Count; i++)
            {
                if (item.val <= kit[i] )
                {
                    kit.Insert(i, item.val);
                    break;
                }
                
                if(i == kit.Count - 1)
                {
                    kit.Add(item.val);
                    break;
                }
            }
            item = item.next;
        }



    }
    ListNode head = new ListNode();
    ListNode tail = head;

    foreach (int item in kit)
    {
        tail.next = new ListNode(item);
        tail = tail.next;
    }

    return head.next;
}



public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
