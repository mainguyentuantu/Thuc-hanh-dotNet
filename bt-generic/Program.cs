
namespace Programs{
class Programs{
class Product<A>{
    A ID;

    public void SetID(A _id){
        this.ID = _id ;
    }

    public void PrintInf(){
        System.Console.WriteLine($"ID = {this.ID}");
    }

}

static void Main(string[] args)
{
    Product<int> sanpham1 = new Product<int>();

    sanpham1.SetID(123);
    sanpham1.PrintInf();

    Product<String> sanpham2 = new Product<string>();

    sanpham2.SetID("tuan tu");
    sanpham2.PrintInf();

}
}
}