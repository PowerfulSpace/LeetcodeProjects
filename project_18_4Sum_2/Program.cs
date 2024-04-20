

int[] input1 = { 1, 0, -1, 0, -2, 2 };
int[] input2 = { 2, 2, 2, 2, 2 };
int[] input3 = { -3, -1, 0, 2, 4, 5 };
int[] input4 = { -2, -1, -1, 1, 1, 2, 2 };

//FourSum(input1, 0);
//FourSum(input2, 8);
//FourSum(input3, 0);
FourSum(input4, 0);


Console.ReadLine();



static IList<IList<int>> FourSum(int[] nums, int target)
{
    if (nums.Length < 4) { return new List<IList<int>>(); }

    List<IList<int>> output = new List<IList<int>>();

    Array.Sort(nums);

    int startIndex = 0;
    int index2 = 1;
    int index3 = nums.Length - 2;
    int endIndex = nums.Length - 1;

    int sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];

    for (int i = 0; i < nums.Length - 3; i++)
    {
        startIndex = i;
        index2 = i + 1;
        index3 = (nums.Length - 2) - i;
        endIndex = (nums.Length - 1) - i;

        if(startIndex >= index2 || index2 >= index3 || index3 >= endIndex) { break; }


        sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
        if (sum == target)
        {
            if (UniquenessCheck(nums[startIndex], nums[index2], nums[index3], nums[endIndex], output))
            {
                output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });
            }            
            index2++;
            sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
        }

        if (startIndex >= index2 || index2 >= index3 || index3 >= endIndex) { break; }

        while (index2 < index3)
        {
            sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];

            if(index2 + 1 == index3) { break; }
            else
            {
                if (sum == target)
                {
                    if (UniquenessCheck(nums[startIndex], nums[index2], nums[index3], nums[endIndex], output))
                    {
                        output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });
                    }
                    index2++;
                }
                else if (sum < target)
                    index2++;
                else if (sum > target)
                    index3--;
            }          
        }

        while (startIndex < index2)
        {
            sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];

            if (startIndex + 1 == index2) { break; }
            else
            {
                if (sum == target)
                {
                    if (UniquenessCheck(nums[startIndex], nums[index2], nums[index3], nums[endIndex], output))
                    {
                        output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });
                    }
                    startIndex++;
                }
                else if (sum < target)
                    startIndex++;
                else if (sum > target)
                    index2--;
            }
        }

        while (index3 < endIndex)
        {
            sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];

            if (index3 + 1 == endIndex) { break; }
            else
            {
                if (sum == target)
                {
                    if (UniquenessCheck(nums[startIndex], nums[index2], nums[index3], nums[endIndex], output))
                    {
                        output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });
                    }
                    index3++;
                }
                else if (sum < target)
                    index3++;
                else if (sum > target)
                    endIndex--;
            }
        }
    }


        return output;
}

static bool UniquenessCheck(int index1, int index2, int index3, int index4, List<IList<int>> lists)
{
    foreach (IList<int> list in lists)
    {
        if(list[0] == index1 && list[1] == index2 && list[2] == index3 && list[3] == index4)
        {
            return false;
        }
    }
    return true;
}