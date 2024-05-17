

int[] nums1 = { 5, 7, 7, 8, 8, 10 };
int[] nums2 = { 5, 7, 7, 8, 8, 10 };
int[] nums3 = {};

Array.ForEach(SearchRange(nums1, 8), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(SearchRange(nums2, 6), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(SearchRange(nums3, 0), x => Console.Write(x + " "));
Console.WriteLine();

Console.ReadLine();



static int[] SearchRange(int[] nums, int target)
{
    int index1 = -1;
    int index2 = -1;

    index1 = nums.ToList().IndexOf(target);
    index2 = nums.Reverse().ToList().IndexOf(target);

    index2 = index2 != -1 ? nums.Length - 1 - index2 : -1;

    return new int[] { index1, index2 };
}


