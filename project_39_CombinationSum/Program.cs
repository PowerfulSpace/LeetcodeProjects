

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    List<IList<int>> result = GetCombination(candidates, new List<IList<int>>(), target, 0,0);

    return result;
}

List<IList<int>> GetCombination(int[] array,List<IList<int>> result, int target, int index,int sum)
{
    if (index == array.Length) { return result; }

    List<int> kit =new List<int>();
    int curIndex = 0;

    while(sum < target)
    {
        sum += array[curIndex];

        if(sum < target)
        {
            GetCombination(array, result, target, index, sum);

            if(sum > target) { return result; }

            kit.Add(array[curIndex]);
        }

        if (sum == target)
        {
            result.Add(kit);
            return result;
        }
        curIndex++;

        GetCombination(array, result, target, index++, sum);
    }

    

    return result;
}
