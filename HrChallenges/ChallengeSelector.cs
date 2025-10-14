using System.Reflection;

namespace HrChallenges.cmd;

internal static class ChallengeSelector
{
    public static void GetChallenges()
    {
        List<string> paths = ChallengeReader.GetChallengesPath();
        int selectedPath = SelectedElement(paths);

        List<string> challenges = ChallengeReader.GetChallengesName(paths[selectedPath - 1]);

        int selectedChallenge = SelectedElement(challenges);

        StartChallenge(challenges[selectedChallenge - 1]);
    }

    public static int SelectedElement(List<string> elements)
    {
        int challengeOption = 0;
        bool wasError = false;

        do
        {
            Console.Clear();

            if (wasError)
                Console.WriteLine("Invalid selection. Please enter a valid option");

            PrintElements(elements);

            int.TryParse(Console.ReadLine(), out challengeOption);

            wasError = true;

        } while (challengeOption <= 0 || challengeOption > elements.Count);

        return challengeOption;
    }

    public static void StartChallenge(string challengeName)
    {
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        Type type = types.SingleOrDefault(t => t.Name == challengeName && typeof(IChallenge).IsAssignableFrom(t))!;

        IChallenge challenge = (IChallenge)Activator.CreateInstance(type)!;

        Console.Clear();

        challenge.StartChallengeConsole();
    }

    private static void PrintElements(List<string> challenges)
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderMessage);

        int i = 0;

        foreach (var item in challenges)
        {
            i++;
            Console.WriteLine("{0}.- {1}", i, item);
        }
    }
}
