

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };
int[] nums4 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

ThreeSum(nums4);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{

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
