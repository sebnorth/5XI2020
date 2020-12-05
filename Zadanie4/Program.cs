using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            int i = a;
            if (i % 2 == 1) i++;

            while (i <= b)
            {
                //if (i % 2 == 0) Console.Write("{0} ",i);

                Console.WriteLine("{0} ", i);

                i+=2;
            }

            Console.ReadKey();

        }
    }
}
