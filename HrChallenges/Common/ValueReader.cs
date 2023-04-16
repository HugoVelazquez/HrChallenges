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

    public static List<string> GetListNStrings(int n)
    {
        List<string> queries = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string queriesItem = Console.ReadLine()!;
            queries.Add(queriesItem);
        }

        return queries;
    }
}
