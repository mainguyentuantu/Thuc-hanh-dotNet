namespace btList
{
    class Program
    {
        /*static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 43, 6, 7, 8, 9, 88, 6, 53, 3, 52, 2, 3, 4, 56, 45, 56, 69, 23, 22, 14, 17, 29, 3 };

           var rs = list.FindAll(
                (e) => { return e % 3 == 0; }
                );

            foreach ( int i in rs )
            {
                Console.WriteLine( i );
            }
        }
*/

            class Product
        {
            public string? Name { get; set; }
            public double Price { get; set; }
            public int ID { get; set; }
            public string? Origin { get; set; }



    }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X", Price = 1000, Origin = "TQ", ID = 1
                },
                new Product()
                {
                    Name = "SamSung", Price = 900, Origin = "HQ", ID = 2
                },
                new Product()
                {
                    Name = "Sony", Price = 1100, Origin = "VN", ID = 3
                },
                new Product()
                {
                    Name = "Nokia", Price = 800, Origin = "JP", ID = 4
                },
                new Product()
                {
                    Name = "Bphone", Price = 500, Origin = "VN", ID = 5
                },
            };

            //Jp
           var rs =  list.Find(
                (p) =>
                {
                    return p.Origin == "JP";
                }
                );

          if ( rs != null )
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{rs.Name} - {rs.Price} - {rs.Origin}");
                Console.ResetColor();

            }


          // price <=900

            var rs1 = list.FindAll(
                (p) =>
                {
                   return p.Price <= 900;
                }
                );

            foreach ( var p in rs1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{p.Name} - {p.Price} - {p.Origin}");
                Console.ResetColor();
            }


            //Sort
            Console.WriteLine("\n");

            foreach (var p in list)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{p.Name} - {p.Price} - {p.Origin}");
                Console.ResetColor();
            }

            list.Sort(
                (p1,p2) =>
                {
                    if ( p1.Price == p2.Price ) return 0;
                    if ( p1.Price < p2.Price ) return -1;
                    return 1;
                }
                );
            Console.WriteLine("---------------------------");

            foreach( var p in list)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{p.Name} - {p.Price} - {p.Origin}");
                Console.ResetColor();
            }


        }
    }
    }