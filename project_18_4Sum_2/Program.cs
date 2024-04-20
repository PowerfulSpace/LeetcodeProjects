

int[] input1 = { 1, 0, -1, 0, -2, 2 };
int[] input2 = { 2, 2, 2, 2, 2 };
int[] input3 = { -3, -1, 0, 2, 4, 5 };
int[] input4 = { -2, -1, -1, 1, 1, 2, 2 };
int[] input5 = { -3, -1, 0, 2, 4, 5 };

//FourSum(input1, 0);
//FourSum(input2, 8);
//FourSum(input3, 0);
FourSum(input4, 0);
FourSum(input5, 2);


Console.ReadLine();



static IList<IList<int>> FourSum(int[] nums, int target)
{
   
}

static bool UniquenessCheck(int index1, int index2, int index3, int index4, List<IList<int>> lists)
{
    foreach (IList<int> list in lists)
    {
        if(list[0] == index1 && list[1] == index2 && list[2] == index3 && list[3] == index4)
        {
            return false;
        }
    }
    return true;
}