namespace HrChallenges.cmd.Common;

internal static class ValueReader
{
    public static List<int> GetIntValuesFromString()
    {
        List<int> arr = Console.ReadLine()!.TrimEnd()
        .Split(' ').ToList()!
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        return arr;
    }
}
