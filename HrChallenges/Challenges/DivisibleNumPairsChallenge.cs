namespace HrChallenges.cmd.Challenges;

internal class DivisibleNumPairsChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderDivisibleNumPairsNK);
        List<int> firstMultipleInput = ValueReader.GetIntValuesFromString();

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);

        Console.WriteLine(ChallengeSelectorConstant.HeaderDivisibleNumPairsAr);
        List<int> list = ValueReader.GetIntValuesFromString();

        Console.WriteLine(DivisibleSumPairs(n, k, list));
    }

    private int DivisibleSumPairs(int n, int k, List<int> ar)
    {
        int firstPair;
        int secondPair;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                firstPair = ar[i];

                if (i != j && i < j)
                    secondPair = ar[j];
                else
                    continue;

                result = (firstPair + secondPair) % k == 0 ? result + 1 : result;
            }
        }

        return result;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
