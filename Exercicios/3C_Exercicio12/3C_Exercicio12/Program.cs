using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>;
            Console.WriteLine("Qtd Funcionarios:");
            int qtdFuncs = int.Parse(Console.ReadLine());
                       
           
            for (int i = 1; i <= qtdFuncs; i++)
            {
                Funcionario f = new Funcionario();
                
                Console.WriteLine("Nome :");
                f.Set_nome(Console.ReadLine());

                Console.WriteLine("Matricula :");
                f.Set_matricula(Console.ReadLine());

                Console.WriteLine("CPF :");
                f.Set_cpf(Console.ReadLine());

                Console.WriteLine("Data Nascimento :");
                f.Set_dataNascimento(Console.ReadLine());
                funcionario.Add(f);  
               
            }//fim for - leitura 



            for (int k = 0; k < funcionario.Count; k++)
            {
                Funcionario func = new Funcionario();

                func = (Funcionario)funcionario[k];

                
             
           
            }// for carros.Count

         
        
        }
    }
}
