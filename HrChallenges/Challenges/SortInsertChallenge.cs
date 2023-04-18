namespace HrChallenges.cmd.Challenges;

internal class SortInsertChallenge : IChallenge
{
    public List<int>? OrderedList { get; set; }

    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        SortInsert(ints);

        OrderedList = ints;
       
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

    private void changeLocation(List<int> arr, int i , int j) 
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
