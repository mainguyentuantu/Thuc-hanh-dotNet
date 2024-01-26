using System.Diagnostics;
using System.Xml.Linq;

namespace btList
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

        //SortList
        static void Main(string[] args)
        {
            SortedList<string, Product> product = new SortedList<string, Product>();
            product["sanpham1"] = new Product { Name = "Iphone X", Price = 1000, Origin = "TQ", ID = 1 };
            product["sanpham2"] = new Product { Name = "SamSung", Price = 900, Origin = "HQ", ID = 2 };
            product.Add("sanpham3", new Product { Name = "Sony", Price = 1100, Origin = "VN", ID = 3});

            var p = product["sanpham2"];
            Console.WriteLine(p.Name);


            //duyet SortList
            var key = product.Keys;
            var value = product.Values;

            foreach (var k in key)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var pro = product[k];
                Console.WriteLine(pro.Name);
            }

            //duyet su dung KeyValuePair
            foreach (KeyValuePair<string,Product> item in product) {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{item.Key} - {item.Value.Name}");
                Console.ResetColor();
            }


        }
    }
}


