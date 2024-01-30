using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace btLinQ
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var brands = new List<Brand>() {
    new Brand{ID = 1, Name = "Công ty AAA"},
    new Brand{ID = 2, Name = "Công ty BBB"},
    new Brand{ID = 4, Name = "Công ty CCC"},
};
            var products = new List<Product>()
{
    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
};

            var qr = from p in products
                     select new
                     {
                         name = p.Name,
                         price = p.Price,
                         descip = "Hoan Thanh"
                     };
            /* foreach (var b in qr)
             {
                 Console.WriteLine(b);
             }*/

            qr.ToList().ForEach(name => Console.WriteLine(name));

            var qr2 = from product in products
                      from color in product.Colors
                      where product.Price <= 500 && color == "Xanh"
                      orderby product.Price

                      select new
                      {
                          Ten = product.Name,
                          Gia = product.Price,
                          cacmau = product.Colors

                      };

            qr2.ToList().ForEach(abc =>
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{abc.Ten} - {abc.Gia} : {string.Join(',', abc.cacmau)}");
                Console.ResetColor();
            });

            var qr3 = from p in products
                      group p by p.Price;

            qr3.ToList().ForEach(group =>
            {
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine(group.Key);
                group.ToList().ForEach(item => Console.WriteLine(item));
                Console.ResetColor() ;
            }
            );

        }
    }
}