

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };
int[] nums4 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    var output = new List<IList<int>>();

    Array.Sort(nums);

    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i > 1 && nums[i] == nums[i - 1]) continue;

        int low = i + 1;
        int high = nums.Length - 1;

        while (low < high)
        {
            int sum = nums[i] + nums[low] + nums[high];

            if (sum == 0)
            {
                var numlist = new List<int>() { nums[i], nums[low], nums[high] };
                bool exists = false;
                foreach (var nlist in output)
                {
                    if (nlist[0] == numlist[0] && nlist[1] == numlist[1] && nlist[2] == numlist[2])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    output.Add(numlist);
                }

                while (low < high && nums[low] == nums[low + 1])
                {
                    low++;
                }
                while (low < high && nums[high] == nums[high - 1])
                {
                    high--;
                }

                low++;
                high--;
            }
            else if (sum < 0)
            {
                low++;
            }
            else
            {
                high--;
            }
        }
    }

    return output;
}