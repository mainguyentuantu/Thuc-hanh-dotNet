using System;

namespace btngoaile{

    class Programe
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 0;

            //Excaption


            try
            {
                var c = a / b;                  //phat sih doi tuong Exception, ke thua Exception
                Console.WriteLine(c);

            }
            catch(Exception e) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("Phep chia co loi.");
                Console.ResetColor();
            }
        finally { Console.WriteLine("Ket Thuc!"); }
        
        }
    }
}