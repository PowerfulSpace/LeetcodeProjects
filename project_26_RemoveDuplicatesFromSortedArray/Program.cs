


int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));


Console.ReadLine();


static int RemoveDuplicates(int[] nums)
{
    if (nums.Length < 1) { return 0; }

    int[] array = nums.ToList().Distinct().ToArray();

    for (int i = 0; i < array.Length; i++)
    {
        nums[i] = array[i];

    }

    return array.Length;
}