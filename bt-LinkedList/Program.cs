
namespace btLinkedList

{
    class Program
    {
        static void Main(string[] args)
        {


            LinkedList<string> cacbaihoc = new LinkedList<string>();

            var bh1 = cacbaihoc.AddFirst("bai hoc 1");
            var bh3 = cacbaihoc.AddLast("bai hoc 3");
            LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "bai hoc 2");

            cacbaihoc.AddLast("bai hoc 4");
            cacbaihoc.AddLast("bai hoc 5");

            foreach (var item in cacbaihoc)
            {
                Console.WriteLine(item);
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            var node = bh2;
            Console.WriteLine(bh2.Value);

            node = node.Next;
            Console.WriteLine(node.Value);

            while (node != null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(node.Value);
                node = node.Previous;
                Console.ResetColor();
            }
        }
    }
}