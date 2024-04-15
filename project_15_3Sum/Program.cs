

int[] nums1 = { -1, 0, 1, 2, -1, -4};
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    if(nums.Length < 3) { return new List<IList<int>>(); }

    List<List<int>> lists = new List<List<int>>();

    int startIndex = 0;
    int endIndex = nums.Length - 1;
    int index = 1;

    for (int i = 1; i < nums.Length - 1; i++)
    {
        Console.Write("(" + nums[i - 1] + " " + nums[i] + " " + nums[i + 1] + ")");
        if(nums[i - 1] + nums[i] + nums[i + 1] == 0)
        {
            CheckOfAddition(lists, new List<int> { nums[i - 1], nums[i], nums[i + 1] });
        }
        
    }
    startIndex = 0;
    Console.WriteLine();
    Console.WriteLine(new string('-', 20));

    for (int i = 2; i < nums.Length; i++)
    {
        Console.Write("(" + nums[startIndex] + " " + nums[startIndex + 1] + " " + nums[i] + ")");
        if (nums[startIndex] + nums[startIndex + 1] + nums[i] == 0)
        {
            CheckOfAddition(lists, new List<int> { nums[startIndex], nums[startIndex + 1], nums[i] });
        }
            
    }
    startIndex = 0;
    Console.WriteLine();
    Console.WriteLine(new string('-', 20));

    for (int i = 0; i < nums.Length; i++)
	{

        for (int j = index; j < endIndex; j++)
        {
            Console.Write("(" + nums[startIndex] + " " + nums[j] + " " + nums[endIndex] + ")");
            if (nums[startIndex] + nums[j] + nums[endIndex] == 0)
            {
                CheckOfAddition(lists, new List<int> { nums[startIndex], nums[j], nums[endIndex] });
            }
                
            index++;
        }
        if(startIndex >= endIndex) { break; }

        Console.WriteLine();
        Console.WriteLine(new string('*', 20));
        Console.WriteLine();
        if (index == endIndex)
        {
            index = startIndex + 1;
        }
        startIndex++;
        endIndex--;

    }
    startIndex = 0;
    endIndex = nums.Length - 1;

    Console.WriteLine();
    Console.WriteLine(new string('-', 20));

    for (int i = 2; i < nums.Length; i++)
    {
        Console.Write("(" + nums[i] + " " + nums[endIndex - 1] + " " + nums[endIndex] + ")");
        if (nums[i] + nums[endIndex - 1] + nums[endIndex] == 0)
        {
            CheckOfAddition(lists, new List<int> { nums[i], nums[endIndex - 1], nums[endIndex] });
        }
            
    }
    endIndex = nums.Length - 1;

    return new List<IList<int>>();
}

static void CheckOfAddition(List<List<int>> lists, List<int> list)
{
    bool flag = false;
    foreach (var item in lists)
    {
        if (item[0] == list[0] && item[1] == list[1] && item[2] == list[2])
        {
            flag = false;
        }
    }
    if(flag == true || lists.Count == 0)
    {
        lists.Add(list);
    }
    
}