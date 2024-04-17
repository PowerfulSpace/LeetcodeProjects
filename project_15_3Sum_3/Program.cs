

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

    for (int i = 0; i < nums.Length; i++)
    {
        while (i > 0 && i < nums.Length - 2 && nums[i] == nums[i - 1])
        {
            i++;
        }

        int target = 0 - nums[i];

        int leftIndex = i + 1;
        int rigthIndex = nums.Length - 1;

        while (leftIndex < rigthIndex)
        {
            if (nums[leftIndex] + nums[rigthIndex] > target)
            {
                rigthIndex--;
            }
            else if (nums[leftIndex] + nums[rigthIndex] < target)
            {
                leftIndex++;
            }
            else
            {
                result.Add(new List<int>() { nums[i], nums[leftIndex], nums[rigthIndex] });

                leftIndex++;

                while (leftIndex < rigthIndex && nums[leftIndex] == nums[leftIndex - 1])
                {
                    leftIndex++;
                }

                rigthIndex--;

                while (leftIndex < rigthIndex && nums[rigthIndex] == nums[rigthIndex - 1])
                {
                    rigthIndex--;
                }

            }
        }

    }

    return result;
}