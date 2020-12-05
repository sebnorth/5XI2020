using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1+2+...+10
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                // s = s + i;
                s += i; // powiększamy s o i
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
