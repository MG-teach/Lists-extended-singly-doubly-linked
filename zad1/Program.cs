namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a doubly linked list:
            // 1 <-> 2 <-> 3 <-> 4
            Node<int> head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Prev = head;
            head.Next.Next = new Node<int>(3);
            head.Next.Next.Prev = head.Next;
            head.Next.Next.Next = new Node<int>(4);
            head.Next.Next.Next.Prev = head.Next.Next;
            Console.WriteLine("Original Doubly Linked List");
            PrintList(head);
            head = Reverser<int>.Reverse(head);
            Console.WriteLine("Reversed Doubly Linked List");
            PrintList(head); ;
        }

        static void PrintList<T>(Node<T> node)
        {
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
