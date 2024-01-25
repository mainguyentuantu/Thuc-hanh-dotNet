using bt_Exception_3;
using System;

namespace btEx
{
    class Program
    {
        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }
            if (age<18 || age > 100)
            {
                throw new AgeException(age);
            }
            //...
            Console.WriteLine($"Xin chao {name} ({age} tuoi)");
        }
        static void Main(string[] args)
        {
            try
            {
                Register("tuantu", 123);
            }
            catch (NameEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }
        }
    }
    
 }