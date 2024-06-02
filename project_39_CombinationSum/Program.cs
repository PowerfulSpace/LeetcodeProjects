

using System.Collections.Generic;

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    Array.Sort(candidates);

    List<IList<int>> result = GetCombination(candidates.ToList(), target, 0, new List<int>(), new List<IList<int>>());

    return result;
}

List<IList<int>> GetCombination(List<int> candidates, int target, int sum, List<int> combo, List<IList<int>> result)
{
    List<int> candidatesCopy = new List<int>(candidates);

    foreach (int item in candidates)
    {
        List<int> kit = new List<int>(combo);

        int sumCoppy = sum + item;

        if (sumCoppy > target) { return result; }

        kit.Add(item);

        if (sumCoppy == target)
        {
            result.Add(kit);
            return result;
        }

        GetCombination(candidatesCopy, target, sumCoppy, kit, result);
        candidatesCopy.RemoveAt(0);
    }


    return result;
}
