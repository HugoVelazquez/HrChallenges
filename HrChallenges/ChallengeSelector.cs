using System.Reflection;

namespace HrChallenges.cmd;

internal static class ChallengeSelector
{
    public static void GetChallenge()
    {
        List<string> challenges = ChallengeReader.GetChallengesName();

        int challengeOption = 0;
        bool wasError = false;

        do
        {
            Console.Clear();

            if (wasError)
                Console.WriteLine("Invalid selection. Please enter a valid option");

            PrintChallenges(challenges);

            int.TryParse(Console.ReadLine(), out challengeOption);

            wasError = true;

        } while (challengeOption <= 0 || challengeOption > challenges.Count);
        

        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        Type type = types.SingleOrDefault(t => t.Name == challenges[challengeOption - 1] && typeof(IChallenge).IsAssignableFrom(t))!;

        IChallenge challenge = (IChallenge)Activator.CreateInstance(type)!;

        Console.Clear();

        challenge.StartChallengeConsole();
    }

    private static void PrintChallenges(List<string> challenges)
    {
        Console.WriteLine(ChallegeSelectorConstant.HeaderMessage);

        int i = 0;

        foreach (var item in challenges)
        {
            i++;
            Console.WriteLine("{0}.- {1}", i, item);
        }
    }
}
