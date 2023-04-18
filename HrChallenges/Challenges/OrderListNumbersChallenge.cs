namespace HrChallenges.cmd.Challenges
{
    internal class OrderListNumbersChallenge : IChallenge
    {
        public List<int>? OrderedList { get; set; }
        public void StartChallengeConsole()
        {
            Console.WriteLine(ChallengeSelectorConstant.HeaderInsertArrayNNumbers);
            List<int> ints = ValueReader.GetIntValuesFromString();

            OrderedList = OrderListNumbers(ints);
        }

        private List<int> OrderListNumbers(List<int> ints)
        {
            List<int> orderedNumbers = new() { ints[0] };
            int indexToInsert;
            int ValueToInsert;
            int orderedCurrentCount;

            for (int i = 0; i < ints.Count; i++)
            {
                indexToInsert = -1;
                ValueToInsert = 0;
                orderedCurrentCount = orderedNumbers.Count;
                for (int j = 0; j < orderedCurrentCount; j++)
                {
                    if (ints[i] < orderedNumbers[j])
                    {
                        indexToInsert = j;
                        ValueToInsert = ints[i];
                        break;
                    }
                    ValueToInsert = j == (orderedCurrentCount - 1) ? ints[i] : ValueToInsert;
                }

                if (indexToInsert > -1)
                    orderedNumbers.Insert(indexToInsert, ValueToInsert);
                else
                    orderedNumbers.Add(ints[i]);
            }

            return orderedNumbers;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
