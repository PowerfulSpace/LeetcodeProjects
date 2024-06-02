

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

List<IList<int>> output;

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    output = new List<IList<int>>();

    Array.Sort(candidates);

    Sum(0, candidates.ToList(), target, new List<int>());

    return output;
}

void Sum(int sum, List<int> candidates, int target, List<int> combination)
{
    List<int> candidatesCopy = new List<int>(candidates);

    foreach (int candidate in candidates)
    {
        List<int> combinationCopy = new List<int>(combination);
        int sumcopy = sum + candidate;

        if (sumcopy > target) return;

        combinationCopy.Add(candidate);

        if (sumcopy == target)
        {
            output.Add(combinationCopy);
            return;
        }

        Sum(sumcopy, candidatesCopy, target, combinationCopy);
        candidatesCopy.RemoveAt(0);
    }
}

