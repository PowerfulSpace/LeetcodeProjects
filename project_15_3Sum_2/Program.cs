

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
    int skip = 2;

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 1; j < 4; j++)
        {
            skip = 2;
            index = skip;
            
            for (int k = j; k < nums.Length - 1; k++)
            {              
                if(index == nums.Length - 2) { index = 1; }

                if (nums[index - 1] + nums[index] + nums[index + 1] == 0)
                {
                    CheckOfAddition(lists, new List<int> { nums[index - 1], nums[index], nums[index + 1] });
                }

                skip--;
                index++;

                Console.Write("(" + nums[k - 1] + " " + nums[k] + " " + nums[k + 1] + ")");
            }




            skip = 1;
            index = skip;

            for (int k = j; k < nums.Length - 1; k++)
            {
                if (index == nums.Length - 1) { index = 1; }

                if (nums[index - 1] + nums[index] + nums[index + 1] == 0)
                {
                    CheckOfAddition(lists, new List<int> { nums[index - 1], nums[index], nums[index + 1] });
                }

                skip--;
                index++;

                Console.Write("(" + nums[k - 1] + " " + nums[k] + " " + nums[k + 1] + ")");
            }



            skip = 0;
            index = skip;

            for (int k = j; k < nums.Length - 1; k++)
            {
                if (index + 2 == nums.Length-1) { index = 1; }

                if (nums[index - 1] + nums[index] + nums[index + 1] == 0)
                {
                    CheckOfAddition(lists, new List<int> { nums[index - 1], nums[index], nums[index + 1] });
                }

                skip--;
                index++;

                Console.Write("(" + nums[k - 1] + " " + nums[k] + " " + nums[k + 1] + ")");
            }




            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }
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