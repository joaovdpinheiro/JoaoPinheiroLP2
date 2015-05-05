using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_execicio4_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int nº1 = 0;
            int nº2 = 0;
            string Comp1 = "1";
            string Comp2 = "2";
            string nomecompetidor;
            bool pontos = true;

            Console.WriteLine("Começo do jogo.");
            Console.WriteLine();

            while (pontos)
            {

                Console.WriteLine("Quem fez o ponto ?");
                nomecompetidor = Console.ReadLine();
                if (Comp1 == nomecompetidor)
                {
                    nº1++;

                }
                else if (Comp2 == nomecompetidor)
                {
                    nº2++;
                }

                if ((nº1 == 21 && nº1 >= nº2 + 2) || (nº1 > 21 && nº1 == nº2 + 2))
                {
                    Console.WriteLine("O Jogador nº1 venceu!");
                    pontos = false;
                }

                else if ((nº2 == 21 && nº2 >= nº1 + 2) || (nº2 == 21 && nº2 >= nº1 + 2))
                {
                    Console.WriteLine("O Jogador nº2 venceu!");
                    pontos = false;
                }

            }

            Console.WriteLine("Pontuação nº1 = {0}", nº1);
            Console.WriteLine("Pontuação nº2 = {0}", nº2);
        }
    }
}
