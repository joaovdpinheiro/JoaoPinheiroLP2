using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_exercicio2_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Soma = 0;
            int Fatorial = 0;

            N = int.Parse(Console.ReadLine());

            for (int j = 1; j <= N; j++)
            {
                double division = Fatorial *= N / (N * 2) + 1;

                N--;

                if (j % 2 == 0)
                {
                    Soma -= division;
                }
                else
                {
                    Soma += division;
                }

            }

            Console.WriteLine(Soma);
        }
    }
}
