using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_Exception_3
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Ten ko duoc rong...")
        { 

        }
    }

    public class AgeException : Exception
    {
        public int age { get; set; }

        public AgeException(int _age) : base("Tuoi ko phu hop...")
        {
            age = _age;
        }

        public void Detail()
        {
            Console.WriteLine($"Tuoi = {age}, khong nam trong khoang [18 - 100]");
        }

      
     }

}

