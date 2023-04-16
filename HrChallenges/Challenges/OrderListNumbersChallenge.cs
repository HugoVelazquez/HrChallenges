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
            List<int> orderedNumbers = new();
            int indexToInsert;
            int ValueToInsert;

            for (int i = 0; i < ints.Count; i++)
            {
                if(orderedNumbers.Count == 0)
                    orderedNumbers.Add(ints[i]);
                else 
                {
                    indexToInsert = -1;
                    ValueToInsert = 0;
                    for (int j = 0; j < orderedNumbers.Count; j++)
                    {
                        if (ints[i] < orderedNumbers[j])
                        {
                            indexToInsert = j;
                            ValueToInsert = ints[i];
                            break;
                        }
                        ValueToInsert = j == (orderedNumbers.Count - 1) ? ints[i] : ValueToInsert;
                    }

                    if (indexToInsert > -1)
                        orderedNumbers.Insert(indexToInsert, ValueToInsert);
                    else
                        orderedNumbers.Add(ints[i]);
                }
            }

            return orderedNumbers;
        }

        public void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
