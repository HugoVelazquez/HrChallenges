namespace HrChallenges.cmd.Challenges.TwoPointersProblems;

public class TwoSumChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        //******Two pointers approach just work with ordered arrays
        Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
        List<int> ints = ValueReader.GetIntValuesFromString();

        Console.WriteLine(ChallengeSelectorConstant.HeaderValueToSearch);

        int.TryParse(Console.ReadLine(), out int target);

        ints.Sort();
        Console.WriteLine(TwoSum(ints, target));
    }

    private bool TwoSum(List<int> ints, int target)
    {
        int left = 0, right = ints.Count - 1, sum = 0;

        while (left < right)
        {
            sum = ints[left] + ints[right];
            if (sum == target)
                return true;
            else if (sum < target)
                left++;
            else
                right--;
        }

        return false;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
