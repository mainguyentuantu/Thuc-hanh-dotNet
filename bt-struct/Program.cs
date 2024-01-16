public struct Product{
    public string name;
    public double price;
    public string Info{
        get{
            return  $"{name} : {price}";
        }
    }

    public string GetInfo(){
        return $"Ten san pham {name}, gia {price}";
    }

    public Product(string _name, double _price){
        name = _name;
        price = _price;
    }

    public override string ToString() => $"{name} : {price}$";



static void Main(string[] args)
{
    Product sanpham1;
    sanpham1.name = "Iphone";
    sanpham1.price = 1000;

    
    Product sanpham2 = new Product("Nokia",900);
    sanpham2 = sanpham1;
    sanpham2.name = "SangSum";
    Console.WriteLine(sanpham1.GetInfo());
    Console.WriteLine(sanpham2.GetInfo());
    Console.WriteLine(sanpham2.Info);

   


}}