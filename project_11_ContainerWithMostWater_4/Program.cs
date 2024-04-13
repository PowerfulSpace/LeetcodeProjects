
int[] input1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int[] input2 = new int[] { 1, 1 };
int[] input3 = new int[] { 4, 3, 2, 1, 4 };
int[] input4 = new int[] { 8, 6, 8, 5, 4, 7 };
int[] input5 = new int[] { 1, 2, 1 };
int[] input6 = new int[] { 2, 1 };

Console.WriteLine(MaxArea(input1));
Console.WriteLine(MaxArea(input2));
Console.WriteLine(MaxArea(input3));
Console.WriteLine(MaxArea(input4));
Console.WriteLine(MaxArea(input5));
Console.WriteLine(MaxArea(input6));



Console.ReadLine();


static int MaxArea(int[] height)
{
    int leftIndex = 0;
    int rightIndex = height.Length - 1;

    int maxArea = CalculateArea(leftIndex, rightIndex, Math.Min(height[leftIndex], height[rightIndex]));

    while (leftIndex + 1 < rightIndex)
    {
        if (height[leftIndex] < height[rightIndex])
        {
            leftIndex++;
        }
        else if (height[leftIndex] > height[rightIndex])
        {
            rightIndex--;
        }
        else
        {
            leftIndex++;
        }

        int area = CalculateArea(leftIndex, rightIndex, Math.Min(height[leftIndex], height[rightIndex]));
        maxArea = Math.Max(maxArea, area);
    }
    return maxArea;
}

static int CalculateArea(int leftIndex, int rightIndex, int height)
{
    return (rightIndex - leftIndex) * height;
}