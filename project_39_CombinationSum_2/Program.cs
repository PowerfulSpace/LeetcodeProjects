

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




    return result;
}
