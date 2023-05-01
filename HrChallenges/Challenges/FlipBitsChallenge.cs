namespace HrChallenges.cmd.Challenges
{
    internal class FlipBitsChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderArraySize);
            int.TryParse(Console.ReadLine(), out int q);

            for (int i = 0; i < q; i++)
            {
                long n = Convert.ToInt64(Console.ReadLine()!.Trim());
                long result = flippingBits(n);
                Console.WriteLine(result);
            }
        }

        private long flippingBits(long n)
        {

            return (long)Math.Pow(2, 32) + ~n;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
