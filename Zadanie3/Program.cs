using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1+2+...+n, gdzie n poda użytkownik

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i < n; i++)
            {
                Console.Write("{0} + ", i);
                // s = s + i;
                s += i; // powiększamy s o i
            }
            Console.Write("{0} ",n);
            s += n;

            Console.Write("= ");
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
