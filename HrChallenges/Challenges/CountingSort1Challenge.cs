namespace HrChallenges.cmd.Challenges
{
    internal class CountingSort1Challenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> arr = ValueReader.GetIntValuesFromString();

            CountingSort(arr);

        }

        public List<int> CountingSort(List<int> arr)
        {
            int[] counting = new int[100];
            foreach (var item in arr)
            {
                counting[item]++;
            }

            return counting.ToList();
        }


        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
