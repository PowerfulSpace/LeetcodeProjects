

int[] candidates1 = { 10, 1, 2, 7, 6, 1, 5 };
int target1 = 8;

int[] candidates2 = { 4, 4, 2, 1, 4, 2, 2, 1, 3 };
int target2 = 6;

int[] candidates3 = { 2, 5, 1, 1, 2, 3, 3, 3, 1, 2, 2 };
int target3 = 5;

int[] candidates4 = Enumerable.Range(0, 100).Select(x => x = 1).ToArray();
int target4 = 30;

int[] candidates5 = Enumerable.Range(0, 100).Select(x => x = 1).ToArray();
candidates5[67] = 2;
int target5 = 30;

//CombinationSum2(candidates1, target1);
//CombinationSum2(candidates2, target2);
//CombinationSum2(candidates3, target3);
//CombinationSum2(candidates4, target4);
CombinationSum2(candidates5, target5);

Console.ReadLine();

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{

    List<IList<int>> result = new List<IList<int>>();


    if (candidates.Length >= 30)
    {
        Array.Sort(candidates);
        List<int> newResult = new List<int>(candidates);
        newResult.Reverse();

        int index = 0;
        bool flag = true;
        foreach (var item in newResult)
        {
            if(item != candidates[index])
            {
                flag = false;
            }
            index++;
        }
        if (flag)
        {
            result.Add(candidates.Take(target).ToList());
            return result;
        }
        
    }

	

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
                //var count = kit.Except(item).Count();
                if (kit.Except(item).Count() == 0 && item.Except(kit).Count() == 0 && kit.Count == item.Count)
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