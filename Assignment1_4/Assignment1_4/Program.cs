using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    class swap
    {
        static void Swap(int a1, int b1)
        {
            a1 = (a1 & b1) + (a1 | b1);
            b1 = a1 + (~b1) + 1;
            a1 = a1 + (~b1) + 1;
            Console.WriteLine("After Swap : " + a1 + "," + b1);
        }
        static void Main()
        {
            int a1 = 15;
            int b1 = 10;
            Swap(a1, b1);
            Console.ReadLine();
        }
    }
}




