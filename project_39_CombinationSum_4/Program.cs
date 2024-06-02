

using System.Collections.Generic;

int[] candidates1 = { 2, 3, 6, 7 };
int target1 = 7;

CombinationSum(candidates1, target1);

Console.ReadLine();

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    IList<IList<int>> ans = new List<IList<int>>();
    Array.Sort(candidates);
    List<int> tryAns = new List<int>();
    Helper(candidates, 0, target, tryAns, 0, ans);
    return ans;
}
void Helper(int[] nums, int index, int target, List<int> tryAns, int sum, IList<IList<int>> ans)
{
    if (sum == target)
    {
        ans.Add(new List<int>(tryAns));
        return;
    }

    if (index >= nums.Length || sum > target)
    {
        return;
    }

    for (int i = index; i < nums.Length; i++)
    {
        if (sum + nums[i] <= target)
        {
            sum += nums[i];
            tryAns.Add(nums[i]);
            Helper(nums, i, target, tryAns, sum, ans); // Pass i instead of index
            sum -= nums[i]; // Backtrack: Remove the last element
            tryAns.RemoveAt(tryAns.Count - 1); // Backtrack: Remove the last element
        }
        else
        {
            break; // Optimization: Stop the loop if further elements will exceed the target
        }
    }
}