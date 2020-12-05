using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ten program oblicza 1+2+...+10
            int i = 1;
            int s = 0;

            while (i<=10)
            {
                s = s + i;
                
                Console.WriteLine("Numewr przebiegu pętli: {0}, aktualna wartość s: {1}",i,s);

                i++;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
