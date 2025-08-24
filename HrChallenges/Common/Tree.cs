using System.Text;

namespace HrChallenges.cmd.Common;

internal static class Tree
{
    public static string PrintTreeArray(List<List<int>> result, StringBuilder sb)
    {
        foreach (List<int> level in result)
        {
            sb.Append("[");

            PrintTreeArray(level, sb);

            sb.Append("]");
            if (level != result.Last())
                sb.Append(", ");
        }

        return sb.ToString();
    }

    public static string PrintTreeArray(List<int> result, StringBuilder sb)
    {
        foreach (int value in result)
        {
            sb.Append(value);
            if (value != result.Last())
                sb.Append(", ");
        }

        return sb.ToString();
    }
}
