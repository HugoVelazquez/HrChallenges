namespace HrChallenges.cmd.Challenges;

internal class MiniMaxSumChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallegeSelectorConstant.HeaderMinMax);
        List<int> ints = ValueReader.GetIntValuesFromString();
        MiniMax(ints);
    }

    public void MiniMax(List<int> list)
    {
        int n = list.Count;
        long operationResult = 0L;
        long min = long.MaxValue;
        long max = 0L;

        for (int i = 0; i < n; i++)
        {
            operationResult += list[i];
            if (list[i] < min)
                min = list[i];
            if (list[i] > max)
                max = list[i];

            min = list[i] < min ? list[i] : min;
            max = list[i] > max ? list[i] : max;
        }

        Console.WriteLine("{0} {1}", operationResult - max, operationResult - min);
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
