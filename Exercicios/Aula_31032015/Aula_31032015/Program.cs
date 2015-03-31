using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Digite o primeiro número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int y = int.Parse(Console.ReadLine());
            result = x *= y;
            Console.WriteLine("O resultado é: " + result);
            Console.ReadKey();
        }
    }
}
