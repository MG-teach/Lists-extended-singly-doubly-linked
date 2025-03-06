namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a hard-coded linked list:
            // 10 -> 20 -> 30 -> 40 -> 50 -> 60
            Node<int> head = new Node<int>(10);
            head.Next = new Node<int>(20);
            head.Next.Next = new Node<int>(30);
            head.Next.Next.Next = new Node<int>(40);
            head.Next.Next.Next.Next = new Node<int>(50);
            head.Next.Next.Next.Next.Next = new Node<int>(60);
            Console.WriteLine(Reverser<int>.GetMiddle(head));
        }
    }
}
