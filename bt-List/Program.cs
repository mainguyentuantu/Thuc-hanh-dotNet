using System.ComponentModel;

namespace btList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 7,8,9,9};

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.AddRange(new int[] {4,5,6,});

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[list.Count -1]);

            Console.ForegroundColor= ConsoleColor.Cyan;
            list.Insert(0,10);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            list.RemoveAt(2);
            list.Remove(9);
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }



        }
    }
}