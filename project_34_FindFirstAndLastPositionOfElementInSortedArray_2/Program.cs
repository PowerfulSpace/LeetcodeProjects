

int[] nums1 = { 5, 7, 7, 8, 8, 10 };
int[] nums2 = { 5, 7, 7, 8, 8, 10 };
int[] nums3 = { };
int[] nums4 = { 1};

Array.ForEach(SearchRange(nums1, 8), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(SearchRange(nums2, 6), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(SearchRange(nums3, 0), x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(SearchRange(nums4, 1), x => Console.Write(x + " "));
Console.WriteLine();

Console.ReadLine();



static int[] SearchRange(int[] nums, int target)
{
    int index1 = -1;
    int index2 = -1;

    for (int i = 0, j = nums.Length - 1; i <= nums.Length - 1; i++,j--)
    {
        if( index1 != -1 && index2 != -1) { break; }

        if (nums[i] == target && index1 == -1)
        {
            index1 = i;
        }
        if (nums[j] == target && index2 == -1)
        {
            index2 = j;
        }
    }

    return new int[] { index1, index2 };
}


