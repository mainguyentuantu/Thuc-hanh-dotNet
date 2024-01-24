namespace Event
{
    public delegate void SuKienNhapSo(int x);
    // publisher -> class phat sk
    // subsriber -> class nhan sk


    //publisher
    class UserInput
    {
        public SuKienNhapSo? sukiennhapso { get; set; }

        public void Input()
        {

            do
            {
                Console.Write("Nhap vao so nguyen:");
                string? s = Console.ReadLine();
                int i = Int32.Parse(s);
                sukiennhapso?.Invoke(i);

            } 
            while (true);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput intput)
        {
            intput.sukiennhapso = Can;
        }

        public void Can(int i)
        {
            Console.WriteLine($"Tinh can bac hai cua {i} la: {Math.Sqrt(i)} ");

        }
    }

    class BinhPhuong
    {
        public void Sub(UserInput intput)
        {
            intput.sukiennhapso = TinhBinhPhuong;
        }

        public void TinhBinhPhuong(int i)
        {
            Console.WriteLine($"Tinh binh phuong cua {i} la: {i * i}");

        }
    }


    //class main
    class Programs
    {
        static void Main(string[] args)
        {

            UserInput userInput = new UserInput();

            TinhCan tinhcan = new TinhCan();
            tinhcan.Sub(userInput);


            BinhPhuong binhPhuong = new BinhPhuong();   //su kien truyen den chi truyen den doi tuong binhPhuong
                                                        //va hoi dk su kien cua tinhcan
            binhPhuong.Sub(userInput);

            userInput.Input();

        }
    }
}//