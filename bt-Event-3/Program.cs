namespace Event
{
    public delegate void SuKienNhapSo(int x);
    // publisher -> class phat sk
    // subsriber -> class nhan sk


    class DuLieuNhap : EventArgs
    {
        public int data { set; get; }

        public DuLieuNhap(int x) => data = x;
    }



    //publisher
    class UserInput
    {
        //public event SuKienNhapSo? sukiennhapso;

        public event EventHandler sukiennhapso;          //~delegate void KIEU(object? render, EventArgs args)
        public void Input()
        {

            do
            {
                Console.Write("Nhap vao so nguyen:");
                string? s = Console.ReadLine();
                int i = Int32.Parse(s);
                sukiennhapso?.Invoke(this, new DuLieuNhap(i));

            }
            while (true);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput intput)
        {
            intput.sukiennhapso += Can;
        }

        public void Can(object sender, EventArgs e)
        {
            DuLieuNhap dulieunhap = (DuLieuNhap)e;
            int i = dulieunhap.data;

            Console.WriteLine($"Tinh can bac hai cua {i} la: {Math.Sqrt(i)} ");

        }
    }

    class BinhPhuong
    {
        public void Sub(UserInput intput)
        {
            intput.sukiennhapso += TinhBinhPhuong;
        }

        public void TinhBinhPhuong(object sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.data;

            Console.WriteLine($"Tinh binh phuong cua {i} la: {i * i}");

        }
    }


    //class main
    class Programs
    {
        static void Main(string[] args)
        {
            //publisher
            UserInput userInput = new UserInput();

            userInput.sukiennhapso += (sender, e) =>
            {                     //Nhan Bieu thuc lamda

                DuLieuNhap dulieunhap = (DuLieuNhap)e;
                int i = dulieunhap.data;

                Console.WriteLine("Ban vua nhap so:", i);
            };

            //subcriber
            TinhCan tinhcan = new TinhCan();
            tinhcan.Sub(userInput);


            BinhPhuong binhPhuong = new BinhPhuong();   //su kien truyen den doi tuong binhPhuong va TinhCan
            binhPhuong.Sub(userInput);

            userInput.Input();

        }
    }
}//