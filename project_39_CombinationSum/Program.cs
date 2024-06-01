

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    List<IList<int>> result = GetCombination(candidates, new List<IList<int>>(), target, 0);

    return result;
}

List<IList<int>> GetCombination(int[] array,List<IList<int>> result, int target, int index)
{
    if (index == array.Length) { return result; }

    List<int> kit =new List<int>();
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        kit.Add(array[i]);
        if(sum > target) { break; }

        if(sum == target)
        {
            result.Add(kit);
            break;
        }
    }

    GetCombination(array, result, target, index++);

    return result;
}
