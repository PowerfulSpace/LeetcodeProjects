

using System.Linq;

LinkedList<int> list1 = new LinkedList<int> (new int[] {1,2,3});
LinkedList<int> list2 = new LinkedList<int> (new int[] {1,3,4});

Console.WriteLine(MergeTwoLists(list1.First, list2.First));

Console.ReadLine();


static LinkedListNode<int> MergeTwoLists(LinkedListNode<int> list1, LinkedListNode<int> list2)
{

    if(list1 == null) { return list2; }
    if(list2 == null) { return list1; }

    LinkedList<int> kit1 = new LinkedList<int>(list1.List);
    LinkedList<int> kit2 = new LinkedList<int>(list2.List);

    List<int> result = new List<int>();

    foreach (var item in kit1)
        result.Add(item);

    foreach (var item in kit2)
        result.Add(item);

    result.Sort();


    return new LinkedList<int>(result).First;
}
