using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_exercicio8_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int soma = 0;

            Console.WriteLine("Digite N: ");
            N = int.Parse(Console.ReadLine());

            for (int j = 1; j <= N; j++)
            {
                soma += j;

            }

            Console.WriteLine("Resultado: {0}", soma);

            Console.ReadKey();


        }
    }
}
