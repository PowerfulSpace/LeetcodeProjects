

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 3, 2, 1 };
int[] nums3 = { 1, 1, 5 };
int[] nums4 = { 1, 3, 2 };
int[] nums5 = { 2, 3, 1 };
int[] nums6 = { 5, 4, 7, 5, 3, 2 };
int[] nums7 = { 2, 2, 7, 5, 4, 3, 2, 2, 1 };
int[] nums8 = { 1, 4, 3, 2, 2 };

Print(nums1);
Print(nums2);
Print(nums3);
Print(nums4);
Print(nums5);
Print(nums6);
Print(nums7);
Print(nums8);

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
    int index = -1;
    int n = nums.Length;

    for (int i = n - 2; i >= 0; i--)
    {
        if (nums[i] < nums[i + 1])
        {
            index = i;
            break;
        }
    }
    if(index == -1)
    {
        nums.Reverse();
        return;
    }

    for (int i = n - 1; i >= 0; i--)
    {
        if (nums[index] < nums[i])
        {
            int swap = nums[index];
            nums[index] = nums[i];
            nums[i] = swap;
            break;
        }
    }
    Array.Reverse(nums, index + 1, n - (index + 1));

}