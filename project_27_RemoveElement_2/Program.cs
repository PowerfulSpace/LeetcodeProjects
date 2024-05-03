

int[] nums1 = { 3, 2, 2, 3 };
int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };

//Console.WriteLine(RemoveElement(nums1, 3));
Console.WriteLine(RemoveElement(nums2, 2));




Console.ReadLine();



static int RemoveElement(int[] nums, int val)
{
    int index = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[index] = nums[i];
            index++;
        }
    }

    return index;
}