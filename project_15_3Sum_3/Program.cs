

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
    var res = new List<IList<int>>();

    for (int i = 0; i < nums.Length; i++)
    {
        while (i > 0 && i < nums.Length - 2 && nums[i] == nums[i - 1])
        {
            i++;
        }

        int target = 0 - nums[i];
        int left = i + 1, right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] > target)
            {
                right--;
            }
            else if (nums[left] + nums[right] < target)
            {
                left++;
            }
            else
            {
                List<int> list = new();
                list.Add(nums[i]);
                list.Add(nums[left]);
                list.Add(nums[right]);
                res.Add(list);

                left++;
                while (left < right && nums[left] == nums[left - 1])
                {
                    left++;
                }
                right--;
                while (left < right && nums[right] == nums[right + 1])
                {
                    right--;
                }
            }
        }
    }
    return res;
}