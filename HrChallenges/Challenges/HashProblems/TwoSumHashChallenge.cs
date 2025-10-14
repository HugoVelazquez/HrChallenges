namespace HrChallenges.cmd.Challenges.HashProblems;

internal class TwoSumHashChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int target);

        Console.WriteLine(TwoSumHash(ints, target).ToString());
    }

    private bool TwoSumHash(List<int> ints, int target)
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

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
