using System;

namespace Delegate
{
    public delegate void ShowLog(string message);

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

        static void Main(string[] args)
        {
            ShowLog log = null;

            log = Info;
            log?.Invoke("Xin Chao ABC");

            log = Warning;
            log("Hoc ve Delegate");



            log += Info;
            log += Warning;
            log.Invoke("Xin chao tuantu");

        }
    }
}