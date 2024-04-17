

using System;

int[] nums1 = { -1, 0, 1, 2, -1, -4 };
int[] nums2 = { 0, 1, 1 };
int[] nums3 = { 0, 0, 0 };
int[] nums4 = { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };

ThreeSumClosest(nums1,1);

Console.ReadLine();


static int ThreeSumClosest(int[] nums, int target)
{
    if(target <= 0 ) return 0;

    Array.Sort(nums);
    int result = 0;

    for(int i = 0; i < nums.Length; i++)
    {

    }


}