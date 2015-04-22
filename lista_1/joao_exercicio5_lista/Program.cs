using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joao_exercicio5_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            double Distancia_Restante = 600;
            double Combustivel_Restante = 50;
            double Distancia_Percorrida;
            double Combustivel_Usado;
            double Desempenho_Medio;

             while (true)
             {
                 Console.WriteLine("Informe a distancia ja percorrida?");
                 Distancia_Percorrida = double.Parse(Console.ReadLine());

                 Console.WriteLine("Qual foi o gasto de combustivel?");
                 Combustivel_Usado = double.Parse(Console.ReadLine());

                 Distancia_Restante -= Distancia_Percorrida;

                 Combustivel_Restante -= Combustivel_Usado;


                 if (Combustivel_Restante <= 0)
                 {
                     Console.WriteLine("Devido a falta de combustivel, carro não chegou ao seu destino final.");

                     break;
                 }

                 if (Distancia_Restante <= 0)
                 {
                     Console.WriteLine("O carro chegou ao seu destino. ");

                     break;
                }
                 

              Console.WriteLine("Distancia restante: {0} Km \n Combustível restante: {1} L", Distancia_Restante, Combustivel_Restante);
             }

             Desempenho_Medio = (600 - Distancia_Percorrida) / (50 - Combustivel_Usado);
             Console.WriteLine("De acordo com as informaçoes, o desempenho médio do carro foi:{0} Km/L", Desempenho_Medio);

             Console.ReadKey();
       }
    }
}
