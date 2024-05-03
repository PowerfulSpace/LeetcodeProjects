

int[] nums1 = { 3, 2, 2, 3 };
int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };

//Console.WriteLine(RemoveElement(nums1, 3));
Console.WriteLine(RemoveElement(nums2, 2));




Console.ReadLine();



static int RemoveElement(int[] nums, int val)
{
    int k = 0;
    var finalList = new List<int>();

    foreach (int i in nums)
    {
        if (i != val)
        {
            finalList.Add(i);
            k++;
        }
    }
    finalList.ToArray().CopyTo(nums, 0);

    return k;
}