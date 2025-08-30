namespace HrChallenges.cmd.Challenges;

internal class CountingMostFrequentChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(CountingMostFrequest(ints));
    }

    private int CountingMostFrequest(List<int> numbers)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        int n = numbers.Count;

        for (int i = 0; i < n; i++)
            freq[numbers[i]] = freq.ContainsKey(numbers[i]) ? freq[numbers[i]] + 1 : 1;

        int max = 0, result = -1;

        foreach (var entry in freq)
        {
            int value = entry.Key, count = entry.Value;

            if (count > max || count == max && value > result)
            {
                max = count;
                result = value;
            }
        }

        return result;


    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
