
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

    return Subsets(candidates, target);
}

IList<IList<int>> Subsets(int[] candidates, int target)
{
    Array.Sort(candidates);
    var lists = new List<IList<int>>();
    Subsets2(candidates, target, lists, 0, new List<int>(), 0);
    return lists;
}

void Subsets2(int[] nums, int target, IList<IList<int>> lists, int sum, List<int> list, int index)
{
    if (sum > target)
        return;

    if (sum == target)
    {
        lists.Add(new List<int>(list));
        return;
    }

    for (int i = index; i < nums.Length; i++)
    {
        if (i == index || nums[i] != nums[i - 1])
        {
            list.Add(nums[i]);
            sum += nums[i];
            Subsets2(nums, target, lists, sum, list, i + 1);
            sum -= nums[i];
            list.RemoveAt(list.Count - 1);
        }
    }
}

