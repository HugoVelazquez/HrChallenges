namespace HrChallenges.cmd.Challenges.TwoPointersProblems;

public class RemoveAllOccurrencesChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        // https://www.geeksforgeeks.org/dsa/remove-element/

        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int ele);

        Console.WriteLine(RemoveAllOccurrences(ints, ele));
    }

    private int RemoveAllOccurrences(List<int> ints, int ele)
    {
        int k = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] != ele)
            {
                ints[k] = ints[i];
                k++;
            }
        }
        return k;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
