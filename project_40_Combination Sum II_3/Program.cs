
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


CombinationSum2(candidates1, target1);
CombinationSum2(candidates2, target2);
CombinationSum2(candidates3, target3);
CombinationSum2(candidates4, target4);
CombinationSum2(candidates5, target5);

Console.ReadLine();



List<IList<int>> result;

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{
    result = new List<IList<int>>();

    Array.Sort(candidates);

    Backtrack(candidates, 0, 0, target, new List<int>());

    return result;
}

void Backtrack(int[] candidates, int start, int sum, int target, List<int> numbers)
{
    if (sum == target)
    {
        result.Add(numbers.ToList());
        return;
    }

    if (sum > target)
        return;

    var hashSet = new HashSet<int>();
    for (int i = start; i < candidates.Length; i++)
    {
        if (hashSet.Add(candidates[i]))
        {
            numbers.Add(candidates[i]);
            Backtrack(candidates, i + 1, sum + candidates[i], target, numbers);
            numbers.RemoveAt(numbers.Count - 1);
        }
    }
}
