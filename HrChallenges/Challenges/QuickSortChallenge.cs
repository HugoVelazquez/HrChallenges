namespace HrChallenges.cmd.Challenges
{
    internal class QuickSortChallenge : IChallenge
    {
        public List<int>? OrderedList { get; set; }
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> ints = ValueReader.GetIntValuesFromString();

            QuickSort(ints, 0, ints.Count - 1);

            OrderedList = ints;
        }
        private void QuickSort(List<int> ints, int low, int max)
        {
            if (low < max)
            {
                int pi = partition(ints, low, max);

                QuickSort(ints, low, pi - 1);
                QuickSort(ints, pi + 1, max);
            }
        }

        private int partition(List<int> ints, int low, int max)
        {
            int pivot = ints[max];

            int i = low - 1;

            for (int j = low; j <= max - 1; j++)
            {
                if (ints[j] < pivot)
                {
                    i++;
                    ChangePositon(ints, i, j);
                }
            }

            ChangePositon(ints, i + 1, max);

            return i + 1;
        }

        private void ChangePositon(List<int> ints, int i, int j)
        {
            (ints[j], ints[i]) = (ints[i], ints[j]);
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
