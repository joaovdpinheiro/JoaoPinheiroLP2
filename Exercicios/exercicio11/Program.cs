using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de carros: ");
            int numeroCarros = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int totalPessoas = 0;

            List<Carro> TotalCarros = new List<Carro>();


            for (int i = 0; i < numeroCarros; i++)
            {
                Carro carros = new Carro();

                Console.WriteLine("Digite a placa do carro: ");
                string placa = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a marca do carro: ");
                string marca = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a capacidade de passageiros no carro: ");
                int numPassageiros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                carros.SetPlaca(placa);
                carros.SetModelo(modelo);
                carros.SetMarca(marca);
                carros.SetNumeroPassageiros(numPassageiros);
                carros.SetValueToId();

                carros.GetId();
                carros.GetPlaca();
                carros.GetModelo();
                carros.GetMarca();

                TotalCarros.Add(carros);
            }

            int numeroCarrosLotados = 0;

            Console.WriteLine("Digite o ID do carro em que deseja viajar: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int L = j;


            while (j != -1)
            {
                if (L != j)
                {
                    Console.WriteLine("Digite o ID do carro em que deseja viajar: ");
                    j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (j == -1)
                    {
                        break;
                    }

                }
                L = -1;

                if (j > TotalCarros.Count)
                {
                    Console.WriteLine("Carro invalido");
                    Console.WriteLine();
                }

                if (j <= TotalCarros.Count)
                {
                    if (TotalCarros[j - 1].GetNumeroPassageiros() > 0)
                    {
                        int vaga = TotalCarros[j - 1].GetNumeroPassageiros();
                        vaga--;
                        TotalCarros[j - 1].SetNumeroPassageiros(vaga);
                        totalPessoas++;

                        if (vaga == 0)
                        {
                            numeroCarrosLotados++;
                        }
                    }

                    else
                    {
                        Console.WriteLine("O carro solicitado já está lotado!");
                        Console.WriteLine();

                        if (numeroCarrosLotados == numeroCarros)
                        {
                            break;
                        }

                    }
                }


            }

            for (int k = 0; k < numeroCarros; k++)
            {
                Console.WriteLine("Carro: " + " Id- " + (k + 1) + " Marca- " + TotalCarros[k].GetMarca() + " Modelo- " + TotalCarros[k].GetModelo() + " Placa- " + TotalCarros[k].GetPlaca());
                Console.WriteLine("Vagas Restantes: " + TotalCarros[k].GetNumeroPassageiros());
                Console.WriteLine();
            }

            Console.WriteLine("Número de pessoas na viagem: " + totalPessoas);

            Console.ReadKey();
        }
    }
}
