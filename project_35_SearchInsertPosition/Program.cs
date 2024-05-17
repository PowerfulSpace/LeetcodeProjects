

int[] nums1 = { 1, 3, 5, 6 };

Console.WriteLine(SearchInsert(nums1, 5));
Console.WriteLine(SearchInsert(nums1, 2));
Console.WriteLine(SearchInsert(nums1, 7));

Console.ReadLine();



static int SearchInsert(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] >= target) { return i; }
    }

    return nums.Length;
}


