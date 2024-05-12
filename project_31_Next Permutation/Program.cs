

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 3, 2, 1 };
int[] nums3 = { 1, 1, 5 };
int[] nums4 = { 1, 3, 2 };
int[] nums5 = { 2, 3, 1 };

NextPermutation(nums1);
NextPermutation(nums2);
NextPermutation(nums3);
NextPermutation(nums4);
NextPermutation(nums5);

Array.ForEach(nums1,x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(nums2,x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(nums3,x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(nums4,x => Console.Write(x + " "));
Console.WriteLine();
Array.ForEach(nums5, x => Console.Write(x + " "));
Console.WriteLine();


Console.ReadLine();

static void NextPermutation(int[] nums)
{
    if(nums.Length <= 1) { return; }

	bool isSortDesc = false;

	for (int i = nums.Length - 1; i > 0; i--)
	{
        if (i != nums.Length - 1 && nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
        {
            if(nums[i - 1] < nums[i + 1])
            {
                int swap = nums[i - 1];
                nums[i - 1] = nums[i + 1];
                nums[i + 1] = nums[i];
                nums[i] = swap;
                break;
            }
            if (nums[i - 1] > nums[i + 1])
            {
                int swap = nums[i - 1];
                nums[i - 1] = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = swap;
                break;
            }
        }

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