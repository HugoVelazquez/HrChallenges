namespace HrChallenges.cmd.Common
{
    internal class SinglyNode
    {
        public int Data;
        public SinglyNode? Next;

        public SinglyNode(int data)
        {
            this.Data = data;
        }

        public SinglyNode()
        {
            this.Data = 1;
            this.Next = new SinglyNode(2);
            this.Next.Next = new SinglyNode(3);
            this.Next.Next.Next = new SinglyNode(4);
            this.Next.Next.Next.Next = new SinglyNode(5);
        }
    }
}
