namespace HrChallenges.cmd.Challenges.NoGroup
{
    internal class MediaQuickSortChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> arr = ValueReader.GetIntValuesFromString();

            QuickSort(arr, 0, arr.Count - 1);

            ValuePrinter.PrintArryOneLine(arr);

            var result = GetMedia(arr);

            Console.WriteLine(string.Format("{0:0.0}", result));
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

        private int GetMedia(List<int> arr)
        {
            int count = arr.Count;
            int position;
            int result;

            if (count % 2 == 0)
            {
                position = count / 2;
                result = (arr[position] + arr[position - 1]) / 2;
            }
            else
            {
                position = (count - 1) / 2;
                result = arr[position];
            }

            return result;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
