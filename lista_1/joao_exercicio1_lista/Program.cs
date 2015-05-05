using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_exercicio1_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int Result = 1;

            N = int.Parse(Console.ReadLine());

            while (N > 0)
            {
                Result *= N;
                N--;
            }

            Console.WriteLine(Result);

            Console.ReadKey();
        
        }
    }
}
