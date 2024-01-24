using System;

namespace Programs
{
    //public delegate void ShowLog(string message);

    public class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

       static int Tong(int a, int b) => a + b;
        static int Hieu(int a, int b) => a - b;



        static void Main(string[] args)
        {
            Action action;                  //~delegate void KIEU() không tham so
            Action<string, int> action1;    //~delegate void KIEU(string s,int i); 


            Action<string> action2;         //~delegate void KIEU(string s);

            action2 = Warning;
            // action1 = Warning;               //LOI
            action2 += Info;
            action2?.Invoke("Thong bao tu ACTION");



            Func<int> f1;                   //~delegate int KIEU() ko tham so
            Func<string, double, string> f2 //~dalegate string KIEU(string s, double d)

                Func<int, int, int> tinhtoan;       //~delegate int KIEU(int a, int b)
            int a = 5;
            int b = 10
                tinhtoan 

        }
    }
}