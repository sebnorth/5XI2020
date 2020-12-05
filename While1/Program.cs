using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<=10)
            {
                
                Console.WriteLine("Numer przebiegu pętli: {0}", i);
                i = i + 1;
            }

            Console.ReadKey();
        }
    }
}
