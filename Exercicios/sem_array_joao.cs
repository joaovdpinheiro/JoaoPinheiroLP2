using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_array_joao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int media;
            int n = 1;
            int i = 0;

            while (n != 0)
            {
                Console.WriteLine("Digite um valor para n: ");
                n = int.Parse(Console.ReadLine());

                num += n;
                i++;
            }

            Console.WriteLine();
            media = num / (i - 1);

            Console.WriteLine("A média aritmética dos números é: " + media);
        }
    }
}
