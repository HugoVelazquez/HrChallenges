namespace HrChallenges.cmd.Common;

internal static class ValuePrinter
{
    public static void PrintArryOneLine(List<int> arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
