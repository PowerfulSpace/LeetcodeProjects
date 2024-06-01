

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    List<IList<int>> result = GetCombination(candidates, new List<IList<int>>(), target, 0, 0, new List<int>());

    return result;
}

List<IList<int>> GetCombination(int[] array, List<IList<int>> result, int target, int index, int sum, List<int> list)
{
    if (index == 3)
    {
        Console.WriteLine();
    }
    if (index == array.Length || sum > target) { return result; }

    List<int> kit = new List<int>(list);

    while (sum < target)
    {
        kit.Add(array[index]);
        sum += array[index];

        if (sum == 11)
        {
            Console.WriteLine();
        }

        GetCombination(array, result, target, index, sum, kit.Take(kit.Count).ToList());

        if (sum > target)
        {
            kit.Remove(array[index]);
        }

        if (sum == target)
        {
            result.Add(kit.Take(kit.Count).ToList());
            kit.Clear();
            return result;
        }
        index++;
    }

    return result;
}
