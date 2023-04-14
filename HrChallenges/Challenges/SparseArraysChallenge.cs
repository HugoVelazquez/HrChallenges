using System.IO;

namespace HrChallenges.cmd.Challenges;

internal class SparseArraysChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        int stringsCount = Convert.ToInt32(Console.ReadLine()!.Trim());
        List<string> strings = ValueReader.GetListNStrings(stringsCount);

        int queriesCount = Convert.ToInt32(Console.ReadLine()!.Trim());
        List<string> queries = ValueReader.GetListNStrings(queriesCount);

        List<int> res = MatchingStrings(strings, queries);

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }

    public static List<int> MatchingStrings(List<string> strings, List<string> queries)
    {
        int result = 0;
        List<int> results = new();

        foreach (string query in queries)
        {
            foreach (string value in strings)
            {
                if (value == query)
                    result++;
            }
            results.Add(result);
            result = 0;
        }

        return results;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
