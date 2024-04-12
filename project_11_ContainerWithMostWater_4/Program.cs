
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
    int l = 0;
    int r = height.Length - 1;

    int maxArea = CalculateArea(l, r, Math.Min(height[l], height[r]));

    while (l + 1 != r)
    {
        if (height[l] < height[r])
        {
            l++;
        }
        else if (height[l] > height[r])
        {
            r--;
        }
        else
        {
            l++;
        }
        var calcArea = CalculateArea(l, r, Math.Min(height[l], height[r]));
        maxArea = Math.Max(maxArea, calcArea);
    }

    return maxArea;
}

static int CalculateArea(int indexOne, int indexTwo, int height)
{
    return (indexTwo - indexOne) * height;
}