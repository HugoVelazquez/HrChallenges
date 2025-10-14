namespace HrChallenges.cmd.Challenges.NoGroup;

internal class PlusMinusChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        PlusMunis(ints);
    }

    public static void PlusMunis(List<int> list)
    {
        int n = list.Count;
        int j = 0;

        List<int> listplusMinus = new() { 1, -1, 0 };

        foreach (int i in listplusMinus)
        {
            foreach (var item in list)
            {
                switch (i)
                {
                    case 1:
                        if (item >= i)
                            j++;
                        break;
                    case -1:
                        if (item <= i)
                            j++;
                        break;
                    case 0:
                        if (item == i)
                            j++;
                        break;
                }
            }

            Console.WriteLine(((decimal)j / n).ToString("0.000000"));

            j = 0;
        }
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
