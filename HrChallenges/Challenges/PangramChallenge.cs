namespace HrChallenges.cmd.Challenges;

internal class PangramChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        string s = "We promptly judged antique ivory buckles for the next prize";
        //DUDDDUUDUU
        //DDUUDDUDUUUD

        Console.WriteLine(pangrams(s));
    }

    public string pangrams(string s)
    {
        bool[] results = new bool[26];
        int index = 0;

        foreach (char c in s)
        {
            if ('a' <= c && c <= 'z')
                index = c - 'a';
            else if ('A' <= c && c <= 'Z')
                index = c - 'A';

            results[index] = true;
        }

        foreach (bool b in results)
            if (!b)
                return "not pangram";

        return "pangram";
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
