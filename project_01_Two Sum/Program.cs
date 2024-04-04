
int[] array1 = new int[] { 2, 7, 11, 15 };
int target1 = 9;

int[] array2 = new int[] { 3, 2, 4 };
int target2 = 6;

int[] array3 = new int[] { 3, 3 };
int target3 = 6;

int[] result1 = TwoSum(array1, target1);
int[] result2 = TwoSum(array2, target2);
int[] result3 = TwoSum(array3, target3);

Console.ReadLine();


static int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[2] { i, j };
            }
        }
    }

    return new int[2] { 0,1 };
}