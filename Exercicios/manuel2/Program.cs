using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manuel2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] piscina = new int[M, N];
            int defeitoTot = 0;

            for (int i = 0; i < M; i++)
			{

                int defeitoLinha = 0;

                for (int j = 0; j < N; j++)
                {
                    piscina[i, j] = int.Parse(Console.ReadLine());
                    if (piscina [i,j] == 1)
                    {
                        defeitoTot++;
                        defeitoLinha++;
                    }
                }
                Console.WriteLine("A linha {0} tem {1} azulejos defeituosos." , i , defeitoLinha);
                Console.WriteLine("Total de {0} azulejos defeituosos.", defeitoTot);
			}

            for (int i = 0; i < N; i++)
            {
                int defeitoColuna = 0;

                for (int j = 0; j < M; j++)
                {
                    piscina[i, j] = int.Parse(Console.ReadLine());
                    if (piscina[i, j] == 1)
                    {
                        defeitoColuna++;
                    }
                }
                Console.WriteLine("A coluna {0} tem {1} azulejos defeituosos.", i, defeitoColuna);
            }



            


        }
    }
}
