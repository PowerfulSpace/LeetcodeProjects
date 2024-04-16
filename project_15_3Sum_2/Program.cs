

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };

ThreeSum(nums1);

Console.ReadLine();


static IList<IList<int>> ThreeSum(int[] nums)
{
    if (nums.Length < 3) { return new List<IList<int>>(); }

    List<IList<int>> lists = new List<IList<int>>();

    int index = 0;
    int index2 = -1;
    int index3 = -1;

    for (int j = 0; j < nums.Length - 2; j++)
    {
        index = j;

        for (int k = j; k < nums.Length - 2 + j; k++)
        {
            if (index == nums.Length) { index = 0; }

            if (index == nums.Length - 1)
            {
                index2 = 0;
                index3 = 1;
            }

            if (index == nums.Length - 2)
            {
                index2 = index + 1;
                index3 = 0;
            }
            if (index == nums.Length - 3)
            {
                index2 = 0;
                index3 = 1;
            }

            //скип
            if (index == j + 1 || index == j + 2)
            {
                index += 2;
            }
            if (index == nums.Length) { index = 0; }

            if (nums[index] + nums[j + 1 == nums.Length ? index2 : j + 1] + nums[j + 2 == nums.Length ? index3 : j + 2] == 0)
            {
                CheckOfAddition(lists, new List<int> { nums[index], nums[j + 1 == nums.Length ? index2 : j + 1], nums[j + 2 == nums.Length ? index3 : j + 2] });
            }

            Console.Write("(" + nums[index] + " " + nums[j + 1 == nums.Length ? index2 : j + 1] + " " + nums[j + 2 == nums.Length ? index3 : j + 2] + ")");

            if (index2 != -1 || index3 != -1)
            {
                index2 = -1;
                index3 = -1;
            }
            index++;
        }
        Console.WriteLine();
        Console.WriteLine();


        index = j;
        index2 = -1;
        index3 = -1;

        for (int k = j; k < nums.Length - 2 + j; k++)
        {
            if (index == nums.Length) { index = 0; }

            if (index == nums.Length - 2)
            {
                index2 = index + 1;
                index3 = 0;
            }

            if (j == 0)
            {
                index2 = 1;
                index3 = nums.Length - 1;
            }

            //скип
            if (index == j + 1)
            {
                index += 1;
            }
            if (index == nums.Length) { index = 0; }

            if (nums[index] + nums[j + 1 == nums.Length ? index2 : j + 1] + nums[j != 0 ? j - 1 : index3] == 0)
            {
                CheckOfAddition(lists, new List<int> { nums[index], nums[j + 1 == nums.Length ? index2 : j + 1], nums[j != 0 ? j - 1 : index3] });
            }

            Console.Write("(" + nums[index] + " " + nums[j + 1 == nums.Length ? index2 : j + 1] + " " + nums[j != 0 ? j - 1 : index3] + ")");

            if (index2 != -1 || index3 != -1)
            {
                index2 = -1;
                index3 = -1;
            }
            index++;
        }
        Console.WriteLine();
        Console.WriteLine();



        index = j;
        index2 = -1;
        index3 = -1;

        for (int k = j; k < nums.Length - 2 + j; k++)
        {
            if (index == nums.Length) { index = 0; }

            if (j == 2)
            {
                index2 = 0;
                index3 = 1;
            }
            if (j == 1)
            {
                index2 = nums.Length - 1;
                index3 = 0;
            }

            if (j == 0)
            {
                index2 = nums.Length - 2;
                index3 = nums.Length - 1;
            }

            if (nums[index] + nums[j - 2 <= 0 ? index2 : j - 2] + nums[j - 1 <= 0 ? index3 : j - 1] == 0)
            {
                CheckOfAddition(lists, new List<int> { nums[index], nums[j - 2 <= 0 ? index2 : j - 2], nums[j - 1 <= 0 ? index3 : j - 1] });
            }

            Console.Write("(" + nums[index] + " " + nums[j - 2 <= 0 ? index2 : j - 2] + " " + nums[j - 1 <= 0 ? index3 : j - 1] + ")");

            if (index2 != -1 || index3 != -1)
            {
                index2 = -1;
                index3 = -1;
            }
            index++;
        }
        Console.WriteLine();
        Console.WriteLine();


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