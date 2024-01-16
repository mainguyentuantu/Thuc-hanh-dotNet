class Program{

enum HOCLUC{Kem, TrungBinh, Kha, Gioi}

static void Main(string[] args)
{
    HOCLUC hocluc;
    hocluc = HOCLUC.Kha;

    switch(hocluc){
            case HOCLUC.Kem:
             Console.WriteLine("Hoc luc kem");
             break;

            case HOCLUC.TrungBinh: Console.WriteLine("Hoc luc trung binh");
            break;
            case HOCLUC.Kha: Console.WriteLine("Hoc luc kha");
            break;
            case HOCLUC.Gioi: Console.WriteLine("Hoc luc gioi");
            break;
    }


}
}