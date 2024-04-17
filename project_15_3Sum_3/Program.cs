

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };
int[] nums4 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    Array.Sort(nums);
    IList<IList<int>> result = new List<IList<int>>();
    var hash = new HashSet<(int, int, int)>();
    for (var i = 0; i < nums.Length; i++)
    {
        var mv = nums[i];
        var l = i + 1;
        var r = nums.Length - 1;
        while (l < r)
        {
            var lv = nums[l];
            var rv = nums[r];
            var calValue = mv + lv + rv;
            if (calValue == 0)
            {
                if (!hash.Contains((mv, lv, rv)))
                {
                    result.Add(new List<int>() { mv, lv, rv });
                    hash.Add((mv, lv, rv));
                }

                l++;
                r--;
            }
            else if (calValue > 0)
            {
                r--;
            }
            else
            {
                l++;
            }
        }
    }

    return result;
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
