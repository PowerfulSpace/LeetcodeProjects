

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
   
    if(nums.Length < 4) { return new  List<IList<int>>(); }

    List<IList<int>> output = new List<IList<int>>();

    Array.Sort(nums);

    for (int lower = 0; lower < nums.Length - 3; lower++)
    {
        if(lower > 1 && nums[lower] == nums[lower - 1]) { continue; }

        for (int upper = nums.Length - 1; upper > 2; upper--)
        {
            if (upper < nums.Length - 1 && nums[upper] == nums[upper + 1]) { continue; }

            int low = lower + 1;
            int high = upper - 1;

            while (low < high)
            {
                long sum = (long)nums[lower] + (long)nums[low] + (long)nums[high] + (long)nums[upper];

                if(sum == target)
                {
                    if (UniqueList(nums[lower], nums[low], nums[high], nums[upper], output))
                    {
                        output.Add(new List<int>() { nums[lower], nums[low], nums[high], nums[upper] });
                    }

                    while (low < high && nums[low] == nums[low +1])
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
                else if(sum < target)
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

static bool UniqueList(int index1, int index2, int index3, int index4, List<IList<int>> output)
{
    foreach (var list in output)
    {
        if (list[0] == index1 && list[1] == index2 && list[2] == index3 && list[3] == index4)
        {
            return false;
        }
    }
    return true;
}