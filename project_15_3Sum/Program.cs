

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{

	for (int i = 0; i < nums.Length; i++)
	{
        for (int j = 1; j < nums.Length; j++)
        {
            for (int k = 2; k < nums.Length; k++)
            {
                Console.Write("(" +nums[i] + " " + nums[j] + " " + nums[k]+")");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    return new List<IList<int>>();
}


