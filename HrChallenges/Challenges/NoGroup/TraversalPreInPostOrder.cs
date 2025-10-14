using System.Text;

namespace HrChallenges.cmd.Challenges.NoGroup;

internal class TraversalPreInPostOrder() : IChallenge
{
    private const int PREORDER = 1;
    private const int INORDER = 2;
    private const int POSTORDER = 3;

    public void StartChallengeConsole()
    {
        Console.WriteLine(ChallengeSelectorConstant.HeaderTreeOrder);
        int.TryParse(Console.ReadLine()!, out int selectedOption);

        Node root = new();

        ProcessTree(root, selectedOption);
    }

    public void ProcessTree(Node root, int selectedOption)
    {
        List<int> result = new();

        switch (selectedOption)
        {
            case PREORDER:
                PreorderRecursive(root, result);
                break;

            case INORDER:
                InorderRecursive(root, result);
                break;

            case POSTORDER:
                PostorderRecursive(root, result);
                break;
        }

        Console.WriteLine(Tree.PrintTreeArray(result, new StringBuilder()));
    }

    public void PreorderRecursive(Node root, List<int> result)
    {
        if (root == null)
            return;

        result.Add(root.data);

        if (root.left != null)
            PreorderRecursive(root.left, result);

        if (root.right != null)
            PreorderRecursive(root.right, result);

    }

    public void InorderRecursive(Node root, List<int> result)
    {
        if (root == null)
            return;

        if (root.left != null)
            InorderRecursive(root.left, result);

        result.Add(root.data);

        if (root.right != null)
            InorderRecursive(root.right, result);
    }

    public void PostorderRecursive(Node root, List<int> result)
    {
        if (root == null)
            return;

        if (root.left != null)
            PostorderRecursive(root.left, result);

        if (root.right != null)
            PostorderRecursive(root.right, result);

        result.Add(root.data);
    }

    public void Validation()
    {
        throw new NotImplementedException();
    }
}