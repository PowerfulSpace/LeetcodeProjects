

int[] nums1 = { -1, 0, 1, 2, -1, -4};
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    if(nums.Length < 3) { return new List<IList<int>>(); }

    List<IList<int>> lists = new List<IList<int>>();

    int startIndex = 0;
    int endIndex = nums.Length - 1;
    int index = 1;

    int auxiliaryStartIndex = 0;
    int auxiliaryEndIndexIndex = nums.Length - 1;

    for (int i = 1; i < nums.Length - 1; i++)
    {
        if(nums[i - 1] + nums[i] + nums[i + 1] == 0)
            CheckOfAddition(lists, new List<int> { nums[i - 1], nums[i], nums[i + 1] });
    }
    startIndex = 0;



    for (int i = 1; i < nums.Length - 2; i++)
    {
        if (nums[0] + nums[i] + nums[i + 1] == 0)
            CheckOfAddition(lists, new List<int> { nums[0], nums[i], nums[i + 1] });
    }
    for (int i = nums.Length - 2; i > 0; i--)
    {
        if (nums[i] + nums[i - 1] + nums[nums.Length - 1] == 0)
            CheckOfAddition(lists, new List<int> { nums[i], nums[i - 1], nums[nums.Length - 1] });
    }




    for (int i = 2; i < nums.Length; i++)
    {
        if (nums[startIndex] + nums[startIndex + 1] + nums[i] == 0)
            CheckOfAddition(lists, new List<int> { nums[startIndex], nums[startIndex + 1], nums[i] });
    }
    startIndex = 0;

    for (int i = 0; i < nums.Length; i++)
	{
        for (int j = index; j < endIndex; j++)
        {
            if (nums[startIndex] + nums[j] + nums[endIndex] == 0)
                CheckOfAddition(lists, new List<int> { nums[startIndex], nums[j], nums[endIndex] });

            index++;
        }

        for (int k = auxiliaryStartIndex; k < nums.Length - 1; k++)
        {
            if (nums[k] + nums[index] + nums[endIndex] == 0)
                CheckOfAddition(lists, new List<int> { nums[k], nums[index], nums[endIndex] });
        }
        auxiliaryStartIndex = 0;

        for (int k = 0; k > index; k--)
        {
            if (nums[k] + nums[index] + nums[startIndex] == 0)
                CheckOfAddition(lists, new List<int> { nums[k], nums[index], nums[startIndex] });
        }
        auxiliaryEndIndexIndex = nums.Length - 1;

        if (startIndex >= endIndex) { break; }

        if (index == endIndex)
            index = startIndex + 1;

        startIndex++;
        endIndex--;

    }
    startIndex = 0;
    endIndex = nums.Length - 1;

    for (int i = 2; i < nums.Length; i++)
    {
        if (nums[i] + nums[endIndex - 1] + nums[endIndex] == 0)
            CheckOfAddition(lists, new List<int> { nums[i], nums[endIndex - 1], nums[endIndex] });
    }
    endIndex = nums.Length - 1;

    return lists;
}

static void CheckOfAddition(List<IList<int>> lists, List<int> list)
{
    bool flag = true;
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