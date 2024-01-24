using System;
using MyLib;

namespace ExtendsionMethod
{
    class Programs
    {
        static void Main(string[] args)
        {
            double a = 60.5;
            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBacHai());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());


        }
    }
}