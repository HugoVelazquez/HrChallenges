using System.Text;

namespace HrChallenges.cmd.Challenges;

internal class CamelCaseFourChallenge : IChallenge
{
    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderCamelCase);
        var sr = new StreamReader(Console.OpenStandardInput());
        var inputs = sr.ReadToEnd().Split("\r\n").Where(x => x != "").ToList();
         
        ProcessAllStrings(inputs);
    }

    private void ProcessAllStrings(List<string> strings)
    {
        foreach (var item in strings)
        {
             Console.WriteLine(CamelCaseFour(item));
        }
    }

    private string CamelCaseFour(string s)
    {
        List<string> list = s.Split(";").ToList();

        CamelCaseOperation camelCaseOperation = Enum.Parse<CamelCaseOperation>(list[0]);
        CamelCaseType camelCaseType = Enum.Parse<CamelCaseType>(list[1]);
        bool upperStarting = camelCaseType == CamelCaseType.C;
        bool parentesisEnding = camelCaseType == CamelCaseType.M;
        int nextNewWord = 0;
        StringBuilder builder = new(string.Empty);

        switch (camelCaseOperation)
        {
            case CamelCaseOperation.C:
                for (int i = 0; i < list[2].Length; i++)
                {
                    if (list[2].Substring(i, 1).Equals(" "))
                    {
                        nextNewWord = i + 1;
                        continue;
                    }
                    if (upperStarting && i == 0 || nextNewWord == i && nextNewWord != 0)
                    {
                        builder.Append(list[2].Substring(i, 1).ToUpper());
                    }
                    else 
                    {
                        builder.Append(list[2].Substring(i, 1).ToLower());
                    }
                }

                builder = parentesisEnding ? builder.Append("()") : builder;

                break;
            case CamelCaseOperation.S:
                var word = list[2].ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]) && i > 0)
                    {
                        builder.Append(" ");
                    }
                    builder.Append(word[i].ToString().ToLower());
                }

                builder = parentesisEnding ? builder.Replace("()", "") : builder;
                break;
        }

        return builder.ToString();
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}

internal enum CamelCaseOperation
{
    C, //Create
    S, //Split
}

internal enum CamelCaseType
{
    V, //Variable
    M, //Method
    C, //Class
}
