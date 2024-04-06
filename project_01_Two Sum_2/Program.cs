


int[] array1 = new int[] { 2, 7, 11, 15 };
int target1 = 9;

int[] array2 = new int[] { 3, 2, 4 };
int target2 = 6;

int[] array3 = new int[] { 3, 3 };
int target3 = 6;

int[] result1 = TwoSum(array1, target1);
int[] result2 = TwoSum(array2, target2);
int[] result3 = TwoSum(array3, target3);

Print(result1);
Print(result2);
Print(result3);

Console.ReadLine();


static int[] TwoSum(int[] nums, int target)
{
    var dictionary = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if(dictionary.ContainsKey(target - nums[i]))
        {
            int[] result = new int[] { dictionary[target - nums[i]], i };
            return result;
        }
        dictionary[nums[i]] = i;
    }
    return null;
}

static void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item + " ");
    }
    Console.WriteLine();
}