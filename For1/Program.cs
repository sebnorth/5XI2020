using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000 ; i++)
            {
                Console.WriteLine("Numer przebiegu pętli: {0}", i);
            }

            Console.ReadKey();
        }
    }
}
