namespace HrChallenges.cmd.Challenges
{
    internal class LonelyIntegerChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> ints = ValueReader.GetIntValuesFromString();

             var result = Lonelyinteger(ints, ints.Count);

            Console.WriteLine(result);

        }

        public int Lonelyinteger(List<int> a, int n)
        {
            int count = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                count++;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    if (a[i] == a[j])
                        count++;
                }
                if (count < 2)
                    result = a[i];
                count = 0;
            }

            return result;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
