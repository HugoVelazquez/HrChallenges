using System.Text;

namespace HrChallenges.cmd.Challenges;

internal class TraversalLevelOrder : IChallenge
{
    private const int RECURSION = 1;
    private const int QUEUE = 2;

    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderTreeLevelOrder);
        int.TryParse(Console.ReadLine()!, out int selectedOption);

        Node root = new();

        LevelOrder(root, selectedOption);
    }

    public void LevelOrder(Node root, int selectedOption)
    {
        List<List<int>> result = new();

        switch (selectedOption)
        {
            case RECURSION:
                LevelOrderRecursion(root, 0, result);
                break;

            case QUEUE:
                LevelOrderQueue(root, 0, result);
                break;

            default:
                break;
        }

        Console.WriteLine(Tree.PrintTreeArray(result, new StringBuilder()));
    }

    public void LevelOrderRecursion(Node root, int level, List<List<int>> result)
    {
        if (root == null)
            return;

        if (result.Count <= level)
            result.Add(new List<int>());

        result[level].Add(root.data);

        LevelOrderRecursion(root.left!, level + 1, result);
        LevelOrderRecursion(root.right!, level + 1, result);
    }

    public void LevelOrderQueue(Node root, int level, List<List<int>> result)
    {
        if (root == null)
            return;

        Queue<Node> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            // Adding list per level
            result.Add(new List<int>());

            int lenght = queue.Count;

            for (int i = 0; i < lenght; i++)
            {

                Node node = queue.Dequeue();

                result[level].Add(node.data);

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            level++;
        }
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}
