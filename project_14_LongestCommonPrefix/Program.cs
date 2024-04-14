


string[] input1 = { "flower", "flow", "flight" };
string[] input2 = { "dog", "racecar", "car" };
string[] input3 = { "", "b" };
string[] input4 = { "reflower", "flow", "flight" };
string[] input5 = { "flower", "flower", "flower", "flower" };
string[] input6 = { "aaa", "aa", "aaa" };


Console.WriteLine(LongestCommonPrefix(input1));
Console.WriteLine(LongestCommonPrefix(input2));
Console.WriteLine(LongestCommonPrefix(input3));
Console.WriteLine(LongestCommonPrefix(input4));
Console.WriteLine(LongestCommonPrefix(input5));
Console.WriteLine(LongestCommonPrefix(input6));


Console.ReadLine();

static string LongestCommonPrefix(string[] strs)
{
	if(strs.Length == 1) { return string.Concat(strs); }

	int prefixIndex = 0;
	int minPrefix = strs[0].Length;

    for (int i = 1; i < strs.Length; i++)
	{
		if (strs[0] == "") { return ""; }

		for (int k = 0; k < Math.Min(strs[i].Length, strs[i -1].Length); k++)
		{
			if (strs[i-1][k] == strs[i][k])
			{
				prefixIndex++;
            }
			else
			{
				if(k == 0)
				{
					prefixIndex = 0;
                }
				break;
			}
		}
        minPrefix = Math.Min(minPrefix, prefixIndex);
        prefixIndex = 0;

    }

	if(minPrefix == 0) { return ""; }
	return string.Concat(strs[0].Take(minPrefix));
}