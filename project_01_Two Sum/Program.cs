﻿
int[] array = new int[] { 2, 7, 11, 15 };
int target = 9;

int[] result = TwoSum(array, target);

Console.ReadLine();


static int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[2] { i, j };
            }
        }
    }

    return new int[2] { 0,1 };
}