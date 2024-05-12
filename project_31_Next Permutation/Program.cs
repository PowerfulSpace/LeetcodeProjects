

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 3, 2, 1 };
int[] nums3 = { 1, 1, 5 };
int[] nums4 = { 1, 3, 2 };
int[] nums5 = { 2, 3, 1 };

Print(nums1);
Print(nums2);
Print(nums3);
Print(nums4);
Print(nums5);

Console.ReadLine();


static void Print(int[] nums)
{
    Array.ForEach(nums, x => Console.Write(x + " "));
    NextPermutation(nums);
    Console.Write(" - - - ");
    Array.ForEach(nums, x => Console.Write(x + " "));
    Console.WriteLine();
}

static void NextPermutation(int[] nums)
{
    if(nums.Length <= 1) { return; }

	bool isSortDesc = false;

	for (int i = nums.Length - 1; i > 0; i--)
	{
        if (nums[i] > nums[i - 1])
		{
			int swap = nums[i];
			nums[i]	= nums[i - 1];
			nums[i - 1] = swap;
			break;
        }

        if (i - 1 == 0)
		{
            isSortDesc = true;
            break;
        }
	}

	if(isSortDesc)
	{
		Array.Sort(nums);
	}

}