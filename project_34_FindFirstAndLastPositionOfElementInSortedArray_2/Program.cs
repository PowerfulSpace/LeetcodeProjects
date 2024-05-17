

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
    int[] result = new int[2] { -1, -1 };

    for (int i = 0, j = nums.Length - 1; i <= nums.Length - 1; i++,j--)
    {
        if(result[0] != -1 && result[1] != -1) { break; }

        if (nums[i] == target && result[0] == -1)
        {
            result[0] = i;
        }
        if (nums[j] == target && result[1] == -1)
        {
            result[1] = j;
        }
    }

    return result;
}


