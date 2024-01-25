using System;

namespace btngoaile
{

    class Programe
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;

            //Excaption


            try
            {
                var c = a / b;                  //phat sih doi tuong Exception, ke thua Exception
                Console.WriteLine(c);
                int[] i = { 1, 2, 3 };
                var x= i[8];
                Console.WriteLine(x);

            }
            catch (DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Message);
                Console.WriteLine("Phep chia ko duoc chia cho 0.");
                Console.ResetColor();
            }
            catch (IndexOutOfRangeException e1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e1.Message);
                Console.WriteLine("Chi so mang ko phu hop!");
                Console.ResetColor();
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine(e2.GetType().Name);
            }
            
            finally { Console.WriteLine("Ket Thuc!"); }

        }
    }
}