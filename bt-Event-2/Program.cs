namespace Event
{
    public delegate void SuKienNhapSo(int x);
    // publisher -> class phat sk
    // subsriber -> class nhan sk


    //publisher
    class UserInput
    {
        public event SuKienNhapSo? sukiennhapso;

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
            intput.sukiennhapso += Can;
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
            intput.sukiennhapso += TinhBinhPhuong;
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
            //publisher
            UserInput userInput = new UserInput();

            userInput.sukiennhapso += x =>                      //Nhan Bieu thuc lamda
            {
                Console.WriteLine("Ban vua nhap so: ", x);
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