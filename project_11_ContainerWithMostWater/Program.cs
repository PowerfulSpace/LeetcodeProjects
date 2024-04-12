
int[] input1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int[] input2 = new int[] { 1, 1};
int[] input3 = new int[] { 4, 3, 2, 1, 4 };
int[] input4 = new int[] { 8, 6, 8, 5, 4, 7};
int[] input5 = new int[] { 1, 2, 1 };
int[] input6 = new int[] { 2, 1 };
int[] input7 = new int[] { 1, 2, 4, 3 };
int[] input8 = new int[] { 1, 8, 6, 2, 5, 4, 8, 25, 7 };

Console.WriteLine(MaxArea(input1));
Console.WriteLine(MaxArea(input2));
Console.WriteLine(MaxArea(input3));
Console.WriteLine(MaxArea(input4));
Console.WriteLine(MaxArea(input5));
Console.WriteLine(MaxArea(input6));
Console.WriteLine(MaxArea(input7));
Console.WriteLine(MaxArea(input8));


Console.ReadLine();


static int MaxArea(int[] height)
{
    if (height.Length <= 2)
    {
        return height.Min();
    }

    int s = 0;
    int startIndex = 0;
    int endIndex = 0;

    int intermediateResult = 0;
    int difference = 0;


    for (int i = 0; i < height.Length; i++)
    {
        for (int j = 1; j < height.Length; j++)
        {

            difference = Math.Abs(j - i);

            if (difference == 1)
            {
                intermediateResult = height[i] > height[j] ? height[j] : height[i];
            }
            else
            {

                intermediateResult = height[i] > height[j]
                    ? height[j] * difference
                    : height[i] * difference;
            }

            if (intermediateResult > s)
            {
                s = intermediateResult;
                startIndex = i;
                endIndex = j;
            }
        }
    }

    if (height[startIndex] == 1 || height[endIndex] == 1)
    {
        return Convert.ToInt32(Math.Abs(endIndex - startIndex));
    }

    return s;
}