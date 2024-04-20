

int[] input1 = { 1, 0, -1, 0, -2, 2 };
int[] input2 = { 2, 2, 2, 2, 2 };
int[] input3 = { -3, -1, 0, 2, 4, 5 };

//FourSum(input1, 0);
//FourSum(input2, 8);
FourSum(input3, 0);


Console.ReadLine();



static IList<IList<int>> FourSum(int[] nums, int target)
{
    if(nums.Length < 4) { return new List<IList<int>>(); }

    List<IList<int>> output = new List<IList<int>>();
    List<int> quadruplets = new List<int>();

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

        if(index2 >= index3) { break; }

        sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
        if (sum == target)
        {
            output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });
            index2++;
            index3--;
        }

        while (index2 < index3)
        {
            sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
            if (sum == target)
            {
                output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });

                index2++;
                index3--;

                if(index2 >= index3) { break; }

                sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
            }

            if (sum < target)
                index2++;
            else if(sum > target)
                index3--;
            else
            {
                output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });

                index2++;
                index3--;

                if (index2 >= index3) { break; }

                sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];

                while (startIndex < index2)
                {
                    if (sum < target)
                        startIndex++;
                    else if (sum > target)
                        index2--;
                    else
                    {
                        output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });

                        startIndex++;
                        index2--;

                        if (index2 >= index3) { break; }

                        sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
                    }
                }

                while (index3 > endIndex)
                {
                    if (sum < target)
                        index3++;
                    else if (sum > target)
                        endIndex--;
                    else
                    {
                        output.Add(new List<int> { nums[startIndex], nums[index2], nums[index3], nums[endIndex] });

                        index3++;
                        endIndex--;

                        if (index2 >= index3) { break; }

                        sum = nums[startIndex] + nums[index2] + nums[index3] + nums[endIndex];
                    }
                }

            }
        }

    }

    




    return output;
}
