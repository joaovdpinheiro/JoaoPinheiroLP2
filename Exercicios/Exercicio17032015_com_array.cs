using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_com_array_joao
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            int numero = 1;
            int soma = 0;
            int media;

            for (int i = 0; numero != 0; i++)
            {
                Console.WriteLine("Digite um valor de um número: ");
                numero = int.Parse(Console.ReadLine());

                numeros.Add(numero);
                numeros.Remove(0);

                soma += numero;
            }
            Console.WriteLine();

            media = soma / numeros.Count;
            Console.WriteLine("A média é: " + media);

        }
    }
}
