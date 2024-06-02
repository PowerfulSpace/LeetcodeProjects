

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();


IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    IList<IList<int>> res = new List<IList<int>>();
    IList<int> cur = new List<int>();
    dfs(candidates, 0, target, cur, res);
    return res;
}

void dfs(int[] candidates, int level, int remain, IList<int> cur, IList<IList<int>> res)
{
    if (remain < 0)
    {
        return;
    }
    else if (remain == 0)
    {
        IList<int> tmp = new List<int>(cur);
        res.Add(tmp);
        return;
    }
    else
    {
        for (int i = level; i < candidates.Length; i++)
        {
            cur.Add(candidates[i]);
            dfs(candidates, i, remain - candidates[i], cur, res);
            cur.RemoveAt(cur.Count - 1);

        }
    }
}