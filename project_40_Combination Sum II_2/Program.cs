
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

IList<IList<int>> CombinationSum2(int[] candidates, int target)
{

    List<IList<int>> result = new List<IList<int>>();

    return result;
}

void Combinations(int[] candidates, int target, int sum, int index, Dictionary<int, int> comb, List<IList<int>> result)
{

}





