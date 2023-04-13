namespace HrChallenges.cmd.Challenges;

internal class TimeConversionChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallegeSelectorConstant.HeaderTimeConversion);
        string s = Console.ReadLine()!;
        TimeConversion(s);
    }

    public static string TimeConversion(string s)
    {
        List<string> list = s.Split(":").ToList();

        bool isPm = list[2].Contains("PM");
        list[2] = list[2].Substring(0, 2);
        int.TryParse(list[0], out int hour);
        if(!isPm)
            hour = hour < 12 ? hour : 00;
        else
            hour = hour < 12 ? hour + 12 : hour;
        var result = string.Format("{0:00}:{1}:{2}", hour, list[1], list[2]);
        
        Console.WriteLine(result);

        return s;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
