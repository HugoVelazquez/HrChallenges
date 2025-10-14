namespace HrChallenges.cmd.Challenges.TwoPointersProblems;

internal class TwoSumChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int target);

        Console.WriteLine(TwoSum(ints, target).ToString());

        sockMerchant(0, ints);
    }

    private bool TwoSum(List<int> ints, int target)
    {
        HashSet<int> set = new HashSet<int>();

        int n = ints.Count;

        for (int i = 0; i < n; i++)
        {
            int complement = target - ints[i];

            if (set.Contains(complement))
                return true;

            set.Add(ints[i]);
        }

        return false;
    }

    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        int result = 0;
        int value = 0;

        for (int i = 0; i < ar.Count; i++)
            counter[ar[i]] = counter.ContainsKey(ar[i]) ? counter[ar[i]] + 1 : 1;

        foreach (var item in counter)
        {
            if (item.Value > 1)
            {
                value = item.Value % 2 == 0 ? item.Value : item.Value - 1;

                result += value / 2;
            }
        }

        return result;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
