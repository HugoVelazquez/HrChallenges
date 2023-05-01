using System.Text;

namespace HrChallenges.cmd.Challenges;

internal class CountingValleysChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        string steps = "DUDDDUUDUU";
        //DUDDDUUDUU
        //DDUUDDUDUUUD

        Console.WriteLine(countingValleys(8, steps));
    }

    public static int countingValleys(int steps, string path)
    {
        int walks = 0;
        int valleyCount = 0;
        bool isValley = false;

        foreach (char character in path)
        {
            walks = character == 'U' ? walks + 1 : walks - 1;

            if (walks <= -2)
            {
                isValley = true;
            }

            if (walks == 0 && isValley)
            {
                valleyCount++;
                isValley = false;
            }
        }

        return valleyCount;
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
