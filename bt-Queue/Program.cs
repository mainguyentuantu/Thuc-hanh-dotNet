namespace btQueue
{
    class Program
    {
        class Product
        {
            public string? Name { get; set; }
            public double Price { get; set; }
            public int ID { get; set; }
            public string? Origin { get; set; }
        }


        static void Main(string[] args)
        {
            Queue<string> cachoso = new Queue<string>();

            cachoso.Enqueue("Ho so 1");
            cachoso.Enqueue("Ho so 2");
            cachoso.Enqueue("Ho so 3");

            foreach (var item in cachoso)
            {
                Console.WriteLine(item);
            }

            var hoso = cachoso.Dequeue();
            Console.WriteLine($"Xu ly ho so: {hoso} - {cachoso.Count}");

        }
    }
}