namespace HrChallenges.cmd.Challenges
{
    internal class ReversStringInPlaceChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderAlphanumericNoSpaces);
            string input = Console.ReadLine()!;

            Console.WriteLine(ReverseStringInPlace(input.ToCharArray()));
        }

        private string ReverseStringInPlace(char[] input)
        {
            int max = input.Length - 1;
            char caracter = new();
            for (int i = 0; i < input.Length / 2; i++)
            {
                caracter = input[max];
                input[max] = input[i];
                input[i] = caracter;

                max--;
            }

            return new string(input);
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
