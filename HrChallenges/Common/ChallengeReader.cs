namespace HrChallenges.cmd.Common;

internal static class ChallengeReader
{
    public static List<string> GetChallengesName()
    {
        List<string> filePaths = Directory.GetFiles(ChallegesPathConstant.ChallengesPath, "*.cs").ToList();

        return filePaths.Select(filePath => Path.GetFileNameWithoutExtension(filePath)).ToList();
    }
}
