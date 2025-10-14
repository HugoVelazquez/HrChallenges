using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HrChallenges.cmd.Challenges.NoGroup;

internal class LenghtCompressionChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderAlphanumericNoSpaces);
        string original = Console.ReadLine()!;

        Console.WriteLine(ProcessLenghtCompress(original));
    }

    private string ProcessLenghtCompress(string original)
    {
        if (string.IsNullOrEmpty(original))
            return string.Empty;

        StringBuilder sb = new StringBuilder();

        int lenght = original.Length;
        char first, compared;
        int counter = 0;
        bool equal = true;

        for (int i = 0; i < lenght;)
        {
            counter = 1;
            int j = i + 1;
            first = original[i];

            while (equal && j < lenght)
            {
                compared = original[j];
                if (first != compared)
                {
                    equal = false;
                    i = j;

                    break;
                }

                j++;
                counter++;
            }

            sb.Append(first);
            if (counter > 1)
                sb.Append(counter);
            equal = true;

            if (j == lenght)
                break;
        }

        return sb.ToString();
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}