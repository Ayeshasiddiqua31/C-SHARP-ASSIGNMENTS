using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Assignment1Maxmarks
    {
        static void Main()
        {
            int[] grades = new int[5] { 21, 22, 23, 22, 20 };
            int i, high, count;
            count = 5;
            high = grades[0];
            for (i = 1; i < count; i++)
            {
                if (grades[i] > high)
                {
                    high = grades[i];
                }
            }
            Console.WriteLine("max marks={0} ", +high);
            Console.ReadLine();
        }
    }
}
