namespace HrChallenges.cmd.Challenges;

internal class BreakingRecordsChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallegeSelectorConstant.HeaderBreakingRecords);
        List<int> scores = ValueReader.GetIntValuesFromString();

        BreakingRecords(scores);
    }

    public static List<int> BreakingRecords(List<int> scores)
    {
        int scoreMax = scores[0];
        int scoreMin = scores[0];
        int min = 0, max = 0;

        foreach (int score in scores)
        {
            if (score < scoreMin)
            {
                min++;
                scoreMin = score;
            }
            if (score > scoreMax)
            {
                max++;
                scoreMax = score;
            }
        }

        Console.WriteLine("{0} {1}", max, min);

        return new List<int>() {max, min};
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
