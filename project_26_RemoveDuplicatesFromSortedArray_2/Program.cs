


int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));


Console.ReadLine();


static int RemoveDuplicates(int[] nums)
{
    var currentIndex = 0;
    var currentValue = -101;

    foreach (var num in nums)
    {
        if (currentValue == num)
        {
            continue;
        }

        currentValue = num;

        nums[currentIndex] = currentValue;
        currentIndex++;
    }

    return currentIndex;
}