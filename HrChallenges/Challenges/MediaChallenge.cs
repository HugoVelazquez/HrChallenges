namespace HrChallenges.cmd.Challenges
{
    internal class MediaChallenge : IChallenge
    {
        public void StartChallengeConsole()
        {
            OrderListNumbersChallenge orderListNumbersChallenge = new OrderListNumbersChallenge();
            orderListNumbersChallenge.StartChallengeConsole();

            var orderedList = orderListNumbersChallenge.OrderedList;
            var result = GetMedia(orderedList!);

            Console.WriteLine(string.Format("{0:0.0}",result));
        }

        private float GetMedia(List<int> orderedList)
        {
            int count = orderedList.Count;
            int position;
            float result;

            if(count % 2 == 0)
            { 
                position =  count / 2;
                result =(float)(orderedList[position] + orderedList[position - 1]) / 2;
            }
            else
            { 
                position = (count - 1) / 2;
                result = orderedList[position];
            }

            return result;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
