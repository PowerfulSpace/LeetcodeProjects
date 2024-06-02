

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum2(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{
	List<IList<int>> result = new List<IList<int>>();

	Combinations(candidates, target,0,0,new List<int>(),result);

    return result;
}

void Combinations(int[] candidates, int target,int sum,int index,List<int> comb, List<IList<int>> result)
{

    if (sum > target) { return; }

    if (sum == target)
    {
        result.Add(new List<int>(comb));
        return;
    }

    for (int i = index; i < candidates.Length; i++)
    {
        if (sum + candidates[i] <= target)
        {
            sum += candidates[i];
            comb.Add(candidates[i]);

            Combinations(candidates, target, sum, i, comb, result);

            sum -= candidates[i];
            comb.Remove(candidates[i]);
        }
        else
        {
            break;
        }

    }
}