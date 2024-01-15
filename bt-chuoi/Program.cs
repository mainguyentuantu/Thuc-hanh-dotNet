using System.Text;

class Program{
    static void Main(string[] args)
    {
        int year = 2020;
        string thongbao1, thongbao2, thongbao3,thongbao4,thongbao5,thongbao6,thongbao7,thongbao8,thongbao9,thongbao10,thongbao11;
        thongbao1 = $"Xin Chao {year}, nam sau {year + 1}";
        thongbao2 = 
        $@"
        Ho ten: tuan tu
        nam sinh: 2000
        ";
        Console.WriteLine(thongbao1);
        Console.WriteLine(thongbao2);

        thongbao3 = "tuantu, xin chao ban!";

        int dodai = thongbao3.Length;

        foreach (var kytu in thongbao3){
            Console.WriteLine(kytu);
        }

        thongbao4 = thongbao3.Trim();
        Console.WriteLine(thongbao4);

        thongbao5 = thongbao3.ToUpper;
        thongbao6 = thongbao3.ToLower;

        Console.WriteLine(thongbao5);
        Console.WriteLine(thongbao6);
        thongbao7 = thongbao3.Replace("xin chao","chao mung");
        thongbao8 = thongbao3.Insert(0,"2020");
        thongbao9 = thongbao3.Substring(12,8);
        thongbao10 = thongbao3.Remove(10, 5);

        string[] cacchuoicon = thongbao3.Split(' ');
        foreach (var s in cacchuoicon){
            Console.WriteLine(s);
        }

        string[] cacchuoicon2 = {
            "Hoc",
            "Lap",
            "Trinh"
        }
        thongbao11 = string.Join(' ',cacchuoicon2);
        Console.WriteLine(thongbao11);

        StringBuilder thongbao12 = new StringBuilder();
        thongbao12.Append("xin");
        thongbao12.Append(" chao cac ban");

        string kg = thongbao12.ToString();
        







    }



}