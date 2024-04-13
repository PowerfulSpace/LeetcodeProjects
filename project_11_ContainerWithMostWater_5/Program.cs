
int[] input1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int[] input2 = new int[] { 1, 1 };
int[] input3 = new int[] { 4, 3, 2, 1, 4 };
int[] input4 = new int[] { 8, 6, 8, 5, 4, 7 };
int[] input5 = new int[] { 1, 2, 1 };
int[] input6 = new int[] { 2, 1 };
int[] input7 = new int[] { 1, 2, 4, 3 };
int[] input8 = new int[] { 1, 8, 6, 2, 5, 4, 8, 25, 7 };
int[] input9 = new int[] { 1, 2, 4, 3 };
int[] input10 = new int[] { 1, 0, 0, 0, 0, 0, 0, 2, 2 };
int[] input11 = new int[] { 1, 2, 1 };
int[] input12 = new int[] { 2, 3, 4, 5, 18, 17, 6 };
int[] input13 = new int[] { 1, 3, 2, 5, 25, 24, 5 };
int[] input14 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int[] input15 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

Console.WriteLine(MaxArea(input1));
//Console.WriteLine(MaxArea(input2));
//Console.WriteLine(MaxArea(input3));
//Console.WriteLine(MaxArea(input4));
//Console.WriteLine(MaxArea(input5));
//Console.WriteLine(MaxArea(input6));
//Console.WriteLine(MaxArea(input7));
//Console.WriteLine(MaxArea(input8));
//Console.WriteLine(MaxArea(input9));
//Console.WriteLine(MaxArea(input10));
//Console.WriteLine(MaxArea(input11));
//Console.WriteLine(MaxArea(input12));
//Console.WriteLine(MaxArea(input13));
//Console.WriteLine(MaxArea(input14));
//Console.WriteLine(MaxArea(input15));


Console.ReadLine();


static int MaxArea(int[] height)
{
    int leftIndex = 0;
    int rightIndex = height.Length - 1;
    int maxWater = 0;
    while (leftIndex < rightIndex)
    {
        int currentWater = CalculateWater(height, leftIndex, rightIndex);
        maxWater = Math.Max(maxWater, currentWater);
        if (height[leftIndex] <= height[rightIndex])
        {
            leftIndex++;
        }
        else
        {
            rightIndex--;
        }
    }
    return maxWater;
}


static int CalculateWater(int[] heights, int leftIndex, int rightIndex)
{
    int width = rightIndex - leftIndex;
    int height = Math.Min(heights[leftIndex], heights[rightIndex]);
    return width * height;
}