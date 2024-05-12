

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 3, 2, 1 };
int[] nums3 = { 1, 1, 5 };
int[] nums4 = { 1, 3, 2 };
int[] nums5 = { 2, 3, 1 };
int[] nums6 = { 5, 4, 7, 5, 3, 2 };
int[] nums7 = { 2, 2, 7, 5, 4, 3, 2, 2, 1 };
int[] nums8 = { 1, 4, 3, 2, 2 };

//Print(nums1);
//Print(nums2);
//Print(nums3);
//Print(nums4);
//Print(nums5);
//Print(nums6);
//Print(nums7);
Print(nums8);

Console.ReadLine();


static void Print(int[] nums)
{
    Array.ForEach(nums, x => Console.Write(x + " "));
    NextPermutation(nums);
    Console.Write(" - - - ");
    Array.ForEach(nums, x => Console.Write(x + " "));
    Console.WriteLine();
}

static void NextPermutation(int[] nums)
{
    if(nums.Length <= 1) { return; }

	bool isSortDesc = false;

	for (int i = nums.Length -1; i > 0; i--)
	{
        if(i != nums.Length - 1)
        {
            if (nums[i] > nums[i - 1])
            {
                List<int> newArray = new List<int>();
                
                int next = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    if(nums[j] > nums[i - 1] && (next > nums[j]))
                    {
                        next = nums[j];
                    }
                }
                newArray.Add(next);


                List<int> array = nums.Skip(i - 1).Take(nums.Length - (i - 1)).ToList();
                array.Remove(newArray.First());
                array.Sort();
                newArray.AddRange(array);

                int index = i - 1;
                for (int j = 0; j < newArray.Count; j++)
                {
                    nums[index] = newArray[j];
                    index++;
                }
                break;
            }
        }

        if (i != nums.Length - 1 && nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
        {
            if (nums[i - 1] < nums[i + 1])
            {
                int swap = nums[i - 1];
                nums[i - 1] = nums[i + 1];
                nums[i + 1] = nums[i];
                nums[i] = swap;
                break;
            }
            if (nums[i - 1] > nums[i + 1])
            {
                int swap = nums[i - 1];
                nums[i - 1] = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = swap;
                break;
            }
        }

        if (nums[i] > nums[i - 1])
        {
            int swap = nums[i];
            nums[i] = nums[i - 1];
            nums[i - 1] = swap;
            break;
        }

        if (i - 1 == 0)
		{
            isSortDesc = true;
            break;
        }
	}

	if(isSortDesc)
	{
		Array.Sort(nums);
	}


}