namespace HrChallenges.cmd.Common;

internal class Node
{
    public int data;
    public Node? left;
    public Node? right;

    public Node(int key)
    {
        this.data = key;
        this.left = null;
        this.right = null;
    }

    /// <summary>
    /// Consecutive Tree FillTree
    /// </summary>
    /// <returns>Node</returns>
    public Node()
    {
        //        1
        //      /    \ 
        //     2      3
        //   /   \      \
        //  4      5      6
        // /  \   /  \   /  \
        //7    8 9   10 11  12

        // result: // [[1], [2, 3], [4, 5, 6], [7, 8, 9, 10, 11, 12]]

        this.data = (1);

        this.left = new(2);
        this.right = new(3);

        this.left.left = new(4);
        this.left.right = new(5);

        //this.right.left = new(20);
        this.right.right = new(6);

        this.left.left.left = new(7);
        this.left.left.right = new(8);

        this.left.right.left = new(9);
        this.left.right.right = new(10);

        this.right.right.left = new(11);
        this.right.right.right = new(12);
    }
}
