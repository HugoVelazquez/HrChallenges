namespace HrChallenges.cmd.Challenges.NoGroup;

internal class TopKFrequentElementsChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        TopKFrequentElements(ints, 3);
    }

    public List<int> TopKFrequentElements(List<int> ints, int k)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < ints.Count; i++)
            freq[ints[i]] = freq.ContainsKey(ints[i]) ? freq[ints[i]] + 1 : 1;

        int max = freq.Values.Max();

        List<List<int>> buckets = new List<List<int>>();
        for (int i = 0; i <= max; i++)
            buckets.Add(new List<int>());

        foreach (var item in freq)
            buckets[item.Value].Add(item.Key);

        // Collect top k frequent elements
        List<int> res = new List<int>();
        for (int i = max; i >= 1; --i)
        {
            buckets[i].Sort((a, b) => b.CompareTo(a));

            foreach (int num in buckets[i])
            {
                res.Add(num);
                if (res.Count == k)
                    return res;
            }
        }

        return res;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
