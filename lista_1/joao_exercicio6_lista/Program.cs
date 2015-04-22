using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_exercicio6_lista
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura = 0;
            double alturaM1 = 0;
            double alturaM2 = 0;
            int nºmulheres = 0;
            int nºmulheres2 = 0;
            string mulher = "";

            while (mulher != "Fim")
            {

                Console.Write("Nome: ");
                mulher = Console.ReadLine();

                if (mulher != "Fim")
                {

                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    if (altura > alturaM1)
                    {
                        alturaM2 = alturaM1;
                        alturaM1 = altura;
                        nºmulheres = 1;
                    }

                    else if (alturaM1 == altura)
                    {
                        nºmulheres++;
                    }

                    else if (altura > alturaM2)
                    {
                        alturaM2 = altura;
                        nºmulheres2 = 1;
                    }

                    if (alturaM2 == altura)
                    {
                        nºmulheres2++;
                    }

                }

            }

            Console.WriteLine("Altura 1: {0}. Possui {1} com a mesma altura. Altura 2: {2}. Possui {3} com a mesma altura", alturaM1, nºmulheres, alturaM2, nºmulheres2);

        }
    }
}
