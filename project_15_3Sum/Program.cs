

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };
int[] nums4 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    List<IList<int>> lists = new List<IList<int>>();

    if (nums.Length == 3)
    {
        if (nums[0] == 0 && nums[1] == 0 && nums[2] == 0 || (nums[0] + nums[1] + nums[2] == 0))
        {
            lists.Add(nums);
            return lists;
        }
    }
    int count = 0;
    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++)
    {

        for (int j = i; j < nums.Length; j++)
        {
            for (int k = nums.Length - 1; k > j; k--)
            {
                if (i == j || i == k) { break; }
                count++;
                if (i != j && i != k && j != k)
                {
                    if (nums[k] + nums[j] + nums[i] == 0)
                    {
                        List<int> list = new List<int>() { nums[k], nums[j], nums[i] };
                        list.Sort();
                        CheckOfAddition(lists, list);
                    }
                }

            }
        }
    }


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
    if (flag == true || lists.Count == 0)
    {
        lists.Add(list);
    }
}
