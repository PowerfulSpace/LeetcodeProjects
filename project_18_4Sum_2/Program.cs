﻿

int[] input1 = { 1, 0, -1, 0, -2, 2 };
int[] input2 = { 2, 2, 2, 2, 2 };
int[] input3 = { -3, -1, 0, 2, 4, 5 };
int[] input4 = { -2, -1, -1, 1, 1, 2, 2 };
int[] input5 = { -3, -1, 0, 2, 4, 5 };
int[] input6 = { -3, -2, -1, 0, 0, 1, 2, 3 };

FourSum(input1, 0);
//FourSum(input2, 8);
//FourSum(input3, 0);
//FourSum(input4, 0);
//FourSum(input6, 0);


Console.ReadLine();



static IList<IList<int>> FourSum(int[] nums, int target)
{
    var output = new List<IList<int>>();

    Array.Sort(nums);

    for (int lower = 0; lower < nums.Length - 3; lower++)
    {
        if (lower > 1 && nums[lower] == nums[lower - 1]) continue;

        for (int upper = nums.Length - 1; upper >= lower + 3; upper--)
        {
            if (upper < nums.Length - 1 && nums[upper] == nums[upper + 1]) continue;

            int low = lower + 1;
            int high = upper - 1;

            while (low < high)
            {
                long sum = (long)nums[lower] + (long)nums[low] + (long)nums[high] + (long)nums[upper];

                if (sum == target)
                {
                    var numlist = new List<int>() { nums[lower], nums[low], nums[high], nums[upper] };
                    bool exists = false;
                    foreach (var nlist in output)
                    {
                        if (nlist[0] == numlist[0]
                            && nlist[1] == numlist[1]
                            && nlist[2] == numlist[2]
                            && nlist[3] == numlist[3])
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
                else if (sum < target)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
        }
    }

    return output;
}
