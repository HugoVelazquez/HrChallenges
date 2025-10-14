namespace HrChallenges.cmd.Challenges.NoGroup;

internal class LinearSearchChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);
        int.TryParse(Console.ReadLine(), out int number);

        Console.WriteLine(LinearSeach(ints, number));
    }

    private int LinearSeach(List<int> numbers, int number)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == number)
                return i;
        }

        return -1;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
