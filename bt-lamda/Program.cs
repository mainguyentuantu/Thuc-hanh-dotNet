using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Action<string> welcome;
        welcome = s => Console.WriteLine(s);
        welcome?.Invoke("Xin chao ban");

        Action<string,string> ten;
        ten = (mgs, name) =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mgs + " " + name);
            Console.ResetColor();
        };
        ten?.Invoke("Chao ban", "tuantu");

        Func<int, int, int> tinhtoan;
        tinhtoan = (a, b) =>
        {
            int kq = a + b;
            return kq;
        };
       Console.WriteLine(tinhtoan?.Invoke(9, 5));

        int[] mang = { 1, 2, 3, 4, 5, 6, 7 };

        var kq = mang.Select( (int x) =>
        {
            return Math.Sqrt(x);
        });

        foreach (var x in kq) { Console.WriteLine(x); }
    }
}