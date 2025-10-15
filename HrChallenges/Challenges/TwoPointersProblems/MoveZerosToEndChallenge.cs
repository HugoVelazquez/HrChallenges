namespace HrChallenges.cmd.Challenges.TwoPointersProblems;

public class MoveZerosToEndChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        // https://www.geeksforgeeks.org/dsa/move-zeroes-end-array/

        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int ele);

        ValuePrinter.PrintArryOneLine(MoveZerosToEnd(ints));
    }

    private List<int> MoveZerosToEnd(List<int> ints)
    {
        int k = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] != 0)
            {
                (ints[i], ints[k]) = (ints[k], ints[i]);
                k++;
            }
        }
        return ints;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
