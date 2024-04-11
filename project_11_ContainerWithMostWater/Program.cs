
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
    int maxS = 0;
    int max = 1;

    int dif = 1;

    for (int i = 0; i < height.Length; i++)
    {
        for (int j = height.Length - 1; j > i; j--)
        {
            if (height[i] == 1 || height[j] == 1)
            {
                max = 1;
            }
            else
            {
                dif = j - i;
                if (height[i] > height[j])
                {
                    max = height[i] * height[j] * dif;
                }
                else
                {
                    max = height[i] * height[j] * dif;
                }
            }

            if (max > maxS)
            {
                if (height[i] != 1 && height[j] != 1)
                {
                    maxS = max;
                    if (height[i] > height[j])
                    {
                        s = height[j] * height[j];
                    }
                    else
                    {
                        s = height[i] * height[i];
                    }
                }
                else
                {
                    s = height[i] - 1 + j;
                    maxS = s;
                }

            }
        }
    }

    if (max == 1 && s == 1) { return 1; }

    return s;
}