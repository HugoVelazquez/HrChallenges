namespace HrChallenges.cmd.Challenges;

internal class FindDuplicatesChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        FindDuplicates(ints);
    }

    private void FindDuplicates(List<int> ints)
    {
        int n = ints.Count;
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
            freq[ints[i]] = freq.ContainsKey(ints[i]) ? freq[ints[i]] + 1 : 1;

        foreach (var entry in freq)
        {
            int value = entry.Key, count = entry.Value;

            if (count > 1)
                Console.WriteLine(value);
        }
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
