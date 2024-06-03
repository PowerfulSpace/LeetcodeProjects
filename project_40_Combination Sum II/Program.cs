

int[] candidates1 = { 10, 1, 2, 7, 6, 1, 5 };
int target1 = 8;

int[] candidates2 = { 4, 4, 2, 1, 4, 2, 2, 1, 3 };
int target2 = 6;

//CombinationSum2(candidates1, target1);
CombinationSum2(candidates2, target2);

Console.ReadLine();

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{
	List<IList<int>> result = new List<IList<int>>();

	Combinations(candidates, target,0,0,new Dictionary<int,int>(),result);

    return result;
}

void Combinations(int[] candidates, int target,int sum,int index, Dictionary<int,int> comb, List<IList<int>> result)
{

    if (sum > target) { return; }

    if (sum == target)
    {
        List<int> kit = comb.Values.ToList();
        //kit.Sort();

        if(result.Count == 0)
        {
            result.Add(new List<int>(kit));
            return;
        }
        else
        {
            foreach (var item in result)
            {
                var count = item.Except(kit).Count();
                if (count == 0)
                {
                    return;
                }
            }
            result.Add(new List<int>(kit));
            return;
        }
        
    }

    for (int i = index; i < candidates.Length; i++)
    {
        if (sum + candidates[i] <= target && !comb.ContainsKey(i))
        {
            sum += candidates[i];
            comb.Add(i,candidates[i]);

            Combinations(candidates, target, sum, i, comb, result);

            sum -= candidates[i];
            comb.Remove(i);
        }
    }
}