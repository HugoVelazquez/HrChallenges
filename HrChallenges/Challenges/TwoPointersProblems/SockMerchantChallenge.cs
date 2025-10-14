namespace HrChallenges.cmd.Challenges.TwoPointersProblems;

public class SockMerchantChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int target);

        SockMerchant(0, ints);
    }

    public int SockMerchant(int n, List<int> ar)
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
