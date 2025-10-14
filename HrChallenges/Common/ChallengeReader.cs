namespace HrChallenges.cmd.Common;

internal static class ChallengeReader
{
    public static List<string> GetChallengesName(string groupPath)
    {
        string challengesPath = Path.Combine(ChallegesPathConstant.ChallengesPath, groupPath);
        List<string> filePaths = Directory.GetFiles(challengesPath, "*.cs").ToList();

        return filePaths.Select(filePath => Path.GetFileNameWithoutExtension(filePath)).ToList();
    }

    public static List<string> GetChallengesPath()
    {
        List<string> paths = Directory.GetDirectories(ChallegesPathConstant.ChallengesPath, "*").ToList();
        return paths.Where(path => Path.GetFileName(path) != "Interfaces").Select(path => Path.GetFileName(path)).ToList();
    }
}
