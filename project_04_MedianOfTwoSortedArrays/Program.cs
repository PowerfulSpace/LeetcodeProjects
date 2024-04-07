

//int[] nums1 = { 1, 3 };
//int[] nums2 = { 2 };

int[] nums1 = { 1, 2 };
int[] nums2 = { 3, 4 };

double result = FindMedianSortedArrays(nums1, nums2);

Console.WriteLine(result);

Console.ReadLine();




static double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] array = new int[nums1.Length + nums2.Length];

    nums1.CopyTo(array, 0);
    nums2.CopyTo(array, nums1.Length);

    Array.Sort(array);

    int middleIndex = array.Length / 2;

    double median = 0;

    if(array.Length % 2 == 0)
    {
        median = (array[middleIndex - 1] + array[middleIndex]) / 2.0;
    }
    else
    {
        median = array[middleIndex];
    }

    return median;
}

