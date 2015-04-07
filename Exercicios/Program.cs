using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x;
            int num;
            double soma = 0;
            double maior = -1;
            double menor = 1000;

            Console.WriteLine("Digite uma quantidade de números positivos");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os números");
                num = int.Parse(Console.ReadLine());
                soma += numa;

                if (num > maior)

                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine("A soma é {0}: ", soma);
            Console.WriteLine("O maior número é {0}: ", maior);
            Console.WriteLine(" O menor número é {0}: ", menor);
        }
    }
}
