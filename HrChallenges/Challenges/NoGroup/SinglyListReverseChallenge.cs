using System.Text;

namespace HrChallenges.cmd.Challenges.NoGroup;

internal class SinglyListReverseChallenge : IChallenge
{
    private enum SinglyReverseOptions
    {
        Iteratively = 1
    }

    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.SinglyNodeIterative);
        int.TryParse(Console.ReadLine()!, out int selectedOption);

        SinglyListReverse(selectedOption);
    }

    private void SinglyListReverse(int selectedOption)
    {
        switch (selectedOption)
        {
            case (int)SinglyReverseOptions.Iteratively:
                SinglyIterative();
                break;
        }
    }

    private void SinglyIterative()
    {
        SinglyNode current = new();

        PrintSinglyNode(current);

        SinglyNode prev = null;
        SinglyNode next = null;

        while (current != null)
        {
            next = current.Next!;
            current.Next = prev;

            prev = current;
            current = next;
        }

        if (prev != null)
            PrintSinglyNode(prev);
    }

    private void PrintSinglyNode(SinglyNode node)
    {
        StringBuilder sb = new StringBuilder();

        if (node == null)
            return;

        while (node != null)
        {
            sb.Append(node.Data);

            if (node.Next != null)
                sb.Append(" -> ");

            node = node.Next!;

        }

        Console.WriteLine(sb.ToString());
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
