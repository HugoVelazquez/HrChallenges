namespace HrChallenges.cmd.Challenges
{
    internal class MediaSortInsertChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> arr = ValueReader.GetIntValuesFromString();

            SortInsert(arr);

            ValuePrinter.PrintArryOneLine(arr);

            var result = GetMedia(arr);

            Console.WriteLine(string.Format("{0:0.0}",result));
        }

        private void SortInsert(List<int> arr)
        {
            int currentValue, j;

            for (int i = 1; i < arr.Count; i++)
            {
                currentValue = arr[i];
                j = i - 1;

                while (j >= 0 && currentValue < arr[j])
                {
                    changeLocation(arr, j + 1, j);
                    j = j - 1;
                }
            }
        }

        private int GetMedia(List<int> arr)
        {
            int count = arr.Count;
            int position;
            int result;

            if(count % 2 == 0)
            { 
                position =  count / 2;
                result =(arr[position] + arr[position - 1]) / 2;
            }
            else
            { 
                position = (count - 1) / 2;
                result = arr[position];
            }

            return result;
        }

        private void changeLocation(List<int> arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
