

int[] nums1 = { 4, 5, 6, 7, 0, 1, 2 };
int[] nums2 = { 1 };

Console.WriteLine(Search(nums1, 0));
Console.WriteLine(Search(nums1, 3));
Console.WriteLine(Search(nums2, 0));

Console.ReadLine();



static int Search(int[] nums, int target)
{
	if(nums.Length == 0) { return -1; }
	if(nums.Length == 1 && nums[0] != target) { return -1; }

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] == target)
		{
			return i;
		}
	}
	return -1;
}


